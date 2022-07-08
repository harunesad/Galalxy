using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    GameObject target;
    public Vector3 offSet = new Vector3(0, 20, -35);
    float followSpeed = 5;
    void Awake()
    {
        target = GameObject.Find("Galaxy");
    }
    void LateUpdate()
    {
        Follow();
    }
    void Follow()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offSet, Time.deltaTime * followSpeed);

    }
}
