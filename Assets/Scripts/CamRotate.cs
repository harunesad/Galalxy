using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    GameObject sun;
    [SerializeField] Galaxy galaxy;

    private float lastFrameFingerPositionX;
    private float moveFactorX;
    private void Awake()
    {
        sun = GameObject.Find("Sun");
    }
    void Update()
    {
        Invoke("System", 3);
    }
    public void System()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveFactorX = Input.mousePosition.x - lastFrameFingerPositionX;
            lastFrameFingerPositionX = Input.mousePosition.x;
            if (moveFactorX > 0)
            {
                transform.RotateAround(sun.transform.localPosition, Vector3.up, Time.deltaTime * galaxy.rotateCamSpeed);
            }
            if (moveFactorX < 0)
            {
                transform.RotateAround(sun.transform.localPosition, Vector3.up, -Time.deltaTime * galaxy.rotateCamSpeed);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0f;
        }
    }
}
