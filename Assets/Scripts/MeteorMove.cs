using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    Rigidbody meteorRb;
    int meteorIndex;
    Vector3 distanceToPlanets;
    private void Awake()
    {
        meteorRb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        //meteorIndex = Random.Range(0, 4);
        Debug.Log(distanceToPlanets);
        distanceToPlanets = SpawnMeteor.instance.planetsTransform[SpawnMeteor.instance.meteorIndex].position - transform.position;
        distanceToPlanets.Normalize();
        meteorRb.AddForce(distanceToPlanets * 0.1f);
    }
}
