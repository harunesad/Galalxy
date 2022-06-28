using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject background;
    [SerializeField] Camera cam;

    float posx = 0;
    float posCamX = 57;
    float posIncX = 258;
    void Start()
    {
        Instantiate(background, background.transform.position, background.transform.rotation);
    }
    void Update()
    {
        if (cam.transform.position.x > posCamX)
        {
            posx += posIncX;
            Instantiate(background, background.transform.position + new Vector3(posx, 0, 0), background.transform.rotation);
            posCamX += posCamX;
        }
    }
}
