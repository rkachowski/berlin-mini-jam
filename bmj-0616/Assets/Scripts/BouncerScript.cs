using UnityEngine;

public class BouncerScript : MonoBehaviour
{

    float counter = 0;
    public int bouncesPerSecond = 2;
    public float bounceIntensity = 0.2f;

    private int mult = -1;


    public void Update()
    {
        counter += Time.deltaTime;

        if (counter > (double)1 / (double)bouncesPerSecond)
        {
            counter = 0;
            transform.localScale += new Vector3(bounceIntensity * mult, bounceIntensity * mult, 0);
            mult *= -1;
        }
    }
}