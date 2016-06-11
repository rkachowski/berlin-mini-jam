using UnityEngine;

public class GetAttractedScript : MonoBehaviour
{
    GameObject _attractor;
    [RangeAttribute(0.01f, 0.5f)]
    public float speed = 0.5f;
    private SpriteRenderer _renderer;

    public void Start()
    {
        AttractorScript script = (AttractorScript)Object.FindObjectOfType(typeof(AttractorScript));
        _attractor = script.gameObject;
        _renderer = (SpriteRenderer)GetComponent(typeof(UnityEngine.SpriteRenderer));

    }
    public void Update()
    {
        if (AttractorScript.attracting)
        {
            var move = Vector3.MoveTowards(transform.position, _attractor.transform.position, speed);
            if (move.magnitude > 0.1)
            {
                _renderer.flipX = move.x - transform.position.x > 0;

                transform.position = move;
            }
        }
    }
}