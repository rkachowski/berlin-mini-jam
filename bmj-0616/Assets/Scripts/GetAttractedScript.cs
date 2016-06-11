using UnityEngine;

public class GetAttractedScript : MonoBehaviour
{
    GameObject _attractor;
    [RangeAttribute(0.01f,0.5f)]
    public float speed = 0.5f;
    public void Start()
    {
        AttractorScript script = (AttractorScript)Object.FindObjectOfType(typeof(AttractorScript));
        _attractor = script.gameObject;
    }
    public void Update()
    {
        if (AttractorScript.attracting)
        {
            transform.position = Vector3.MoveTowards(transform.position, _attractor.transform.position, speed);
        }
    }
}