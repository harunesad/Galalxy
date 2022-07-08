using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject meteorPrefab;
    GameObject galaxy;
    public List<GameObject> planets;
    GameObject meteorObject;

    float meteorPosX, meteorPosY, meteorPosZ;
    private void Awake()
    {
        galaxy = GameObject.Find("Galaxy");
    }
    void Start()
    {
        InvokeRepeating("SpawnMeteorObject", 0, 5);
    }
    void Update()
    {
        if (meteorObject != null)
        {
            meteorObject.transform.position = Vector3.Lerp(meteorObject.transform.position, planets[Random.Range(0, 4)].transform.position, Time.deltaTime * 1);
        }
    }
    void SpawnMeteorObject()
    {
        meteorPosX = Random.Range(-25, 26);
        meteorPosY = meteorPrefab.transform.position.y;
        meteorPosZ = meteorPrefab.transform.position.z;

        var meteor = Instantiate(meteorPrefab, new Vector3(meteorPosX, meteorPosY, meteorPosZ), Quaternion.identity);
        meteorObject = meteor;

        meteorObject.transform.parent = galaxy.transform;
    }
    void RandomPlanet(int options)
    {
        options = Random.Range(1, 5);
        switch (options)
        {
            case 1:

            default:
                break;
        }
    }
}
