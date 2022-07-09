using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public static SpawnMeteor instance;
    public GameObject meteorPrefab;
    GameObject galaxy;
    public List<Transform> planetsTransform;
    GameObject meteorObject;
    //public Rigidbody meteorRb;

    float meteorPosX, meteorPosY, meteorPosZ;
    public int meteorIndex;
    //Vector3 distanceToPlanets;
    private void Awake()
    {
        galaxy = GameObject.Find("Galaxy");
        instance = this;   
    }
    void Start()
    {
        InvokeRepeating("SpawnMeteorObject", 0, 5);
    }
    void Update()
    {
        //if (meteorObject != null)
        //{
        //    meteorIndex = Random.Range(0, 4);
        //    distanceToPlanets = planets[meteorIndex].transform.position - meteorPrefab.transform.position;
        //    meteorObject.transform.position = Vector3.Lerp(meteorObject.transform.position, planets[Random.Range(0, 4)].transform.position, Time.deltaTime * 1);
        //    distanceToPlanets.Normalize();
        //    meteorRb.AddForce(distanceToPlanets * 1);
        //}
    }
    void SpawnMeteorObject()
    {
        meteorIndex = Random.Range(0, 4);
        meteorPosX = Random.Range(-25, 26);
        meteorPosY = meteorPrefab.transform.position.y;
        meteorPosZ = meteorPrefab.transform.position.z;

        var meteor = Instantiate(meteorPrefab, new Vector3(meteorPosX, meteorPosY, meteorPosZ), Quaternion.identity);
        meteorObject = meteor;

        meteorObject.transform.parent = galaxy.transform;
    }
}
