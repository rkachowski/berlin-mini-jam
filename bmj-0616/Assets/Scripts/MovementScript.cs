using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed = 1.0f;
    private SpriteRenderer _renderer;

    void Start()
    {
        _renderer = (SpriteRenderer)GetComponent(typeof(UnityEngine.SpriteRenderer));
    }

    public void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (move.magnitude > 0.1)
        {
            _renderer.flipX = move.x < 0;
            transform.position += move * speed * Time.deltaTime;
        }
    }
}