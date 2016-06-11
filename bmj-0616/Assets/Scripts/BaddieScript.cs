using System;
using System.Collections.Generic;
using UnityEngine;

public class BaddieScript : MonoBehaviour
{
    public int numberOfPoints = 18;
    List<Vector3> points;
    
    [Range(0.0f, 1f)]
    public float radius = 1;
    private LineRenderer _lineRenderer;

    [Range(0.0f, 0.5f)]
    public float jitterIntensity = 0.03f;
    void Start()
    {
        _lineRenderer = gameObject.AddComponent<LineRenderer>();
        _lineRenderer.SetVertexCount(numberOfPoints + 1);
        _lineRenderer.SetWidth(0.1f, 0.1f);
        _lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        _lineRenderer.SetColors(Color.HSVToRGB(0, 100, 100), Color.HSVToRGB(0, 100, 100));
    }
    public void Update()
    {
        points = new List<Vector3> { };

        int inc = 360 / numberOfPoints;
        for (float ang = 0; ang < (360 + inc); ang += inc)
        {
            float rad = ang * Mathf.Deg2Rad;

            var x = (float)(transform.position.x + (UnityEngine.Random.Range(-jitterIntensity, jitterIntensity) + radius * Math.Cos(rad)));
            var y = (float)(transform.position.y + (UnityEngine.Random.Range(-jitterIntensity, jitterIntensity) + radius * Math.Sin(rad)));
            points.Add(new Vector3(x, y, 0));
        }

        points[points.Count - 1] = points[0];//close the circle
        var color = UnityEngine.Random.ColorHSV(0, 0, 0.7f, 1, 1, 1);

        _lineRenderer.SetColors(color, color);
        _lineRenderer.SetPositions(points.ToArray());
    }
}