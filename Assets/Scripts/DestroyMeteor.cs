using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    float delay = 1.5f;
    void Start()
    {
        if (gameObject != null)
        {
            Destroy(gameObject, delay);
        }
    }
}
