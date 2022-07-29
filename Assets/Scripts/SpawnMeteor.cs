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

    float meteorPosX, meteorPosY, meteorPosZ;
    float repeatTime = 5;
    public int meteorIndex;
    private void Awake()
    {
        galaxy = GameObject.Find("Galaxy");
        instance = this;   
    }
    void Start()
    {
        InvokeRepeating("SpawnMeteorObject", 0, repeatTime);
    }
    void Update()
    {
        if (meteorObject != null)
        {
            meteorObject.transform.position = Vector3.Lerp(meteorObject.transform.position, planetsTransform[meteorIndex].position, Time.deltaTime * 10f);
        }
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
