using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    void Start()
    {
        if (gameObject != null)
        {
            Destroy(gameObject, 2);
        }
    }
    void Update()
    {

    }
}
