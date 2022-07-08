using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDraw : MonoBehaviour
{
    public LineRenderer circleRenderer;
    public int segments;
    public float xradius;
    public float yradius;
    void Start()
    {
        circleRenderer.SetVertexCount(segments + 1);
        circleRenderer.useWorldSpace = false;
        CreatePoints();
    }
    void Update()
    {
        
    }
    void CreatePoints()
    {
        float x;
        float y;
        float z = 0f;

        float angle = 20f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            circleRenderer.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }
}
