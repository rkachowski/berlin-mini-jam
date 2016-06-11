using UnityEngine;
using System.Collections;

public class ChangeOnAttraction : MonoBehaviour {
    private SpriteRenderer _renderer;


	public Sprite idle;
	public Sprite active;
    // Use this for initialization
    void Start () {
		_renderer = (SpriteRenderer)GetComponent(typeof(UnityEngine.SpriteRenderer));
		_renderer.sprite = idle;
	}
	
	// Update is called once per frame
	void Update () {
		if(AttractorScript.attracting)
		{
			_renderer.sprite = active;
		}
		else
		{
			_renderer.sprite = idle;
		}
	}
}
