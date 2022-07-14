using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem smoke;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        smoke.transform.parent = gameObject.transform;
        smoke.transform.position = gameObject.transform.position + new Vector3(0, 1.5f, 0);
        smoke.Play();
    }
}
