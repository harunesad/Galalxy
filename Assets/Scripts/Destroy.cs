using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ParticleSystem smoke;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        smoke.transform.position = gameObject.transform.position + new Vector3(0, 1.5f, 0);
        smoke.Play();
    }
}
