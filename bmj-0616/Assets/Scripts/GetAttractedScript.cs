using UnityEngine;

public class GetAttractedScript : MonoBehaviour
{
    GameObject _attractor;
    [RangeAttribute(0.01f, 0.5f)]
    public float speed = 0.5f;
    private SpriteRenderer _renderer;
    private Rigidbody2D _rigidbody;
    private Hurtable _hurtable;

    public void Start()
    {
        AttractorScript script = (AttractorScript)Object.FindObjectOfType(typeof(AttractorScript));
        _attractor = script.gameObject;
        _renderer = (SpriteRenderer)GetComponent(typeof(UnityEngine.SpriteRenderer));
		_rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _hurtable = gameObject.GetComponent<Hurtable>();

    }
    public void Update()
    {
        if (AttractorScript.attracting && !_hurtable.isHurt())
        {
            var move = Vector3.MoveTowards(transform.position, _attractor.transform.position, speed);
            if (move.magnitude > 0.1)
            {
                _renderer.flipX = move.x - transform.position.x > 0;

                transform.position = move;

                _rigidbody.velocity = Vector3.zero;
                _rigidbody.rotation = 0f;
                _rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;

            }
        }
    }
}