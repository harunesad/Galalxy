using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float rightSpeed = 1;
    void Update()
    {
        RightFollow();
    }
    void RightFollow()
    {
        transform.Translate(Vector3.right * Time.deltaTime * rightSpeed);
    }
}
