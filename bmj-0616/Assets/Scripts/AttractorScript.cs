using UnityEngine;

public class AttractorScript : MonoBehaviour
{

    public static bool attracting = false;
    public void Update()
    {
        attracting = Input.GetButton("attract");
    }
}