using UnityEngine;

public class GetAttractedScript : MonoBehaviour
{
    GameObject _attractor;
    public void Start()
    {
        AttractorScript script = (AttractorScript)Object.FindObjectOfType(typeof(AttractorScript));
        _attractor = script.gameObject;
    }
    public void Update()
    {
        if (AttractorScript.attracting)
        {
            
        }
    }
}