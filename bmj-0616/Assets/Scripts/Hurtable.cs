using UnityEngine;
using System.Collections;

public class Hurtable : MonoBehaviour {

	public float hurtTimer = 0.8f;
	public float counter ;
	// Use this for initialization
	void Start () {
		counter = hurtTimer;
	}
	
	// Update is called once per frame
	void Update () {
		if(counter < hurtTimer) counter += Time.deltaTime;

	}

	public bool isHurt()
	{
		return counter < hurtTimer;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.GetComponent(typeof(Painful)))
		{
			var vec = col.gameObject.transform.position - transform.position;

			var rigidbody = gameObject.GetComponent<Rigidbody2D>();
			rigidbody.AddForce(vec*3,ForceMode2D.Impulse);
			rigidbody.constraints = RigidbodyConstraints2D.None;
			rigidbody.AddTorque(Random.Range(0,10), ForceMode2D.Impulse);

			counter = 0;
		}
	}
}
