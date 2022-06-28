using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float speedRadius;
    float value;

    [SerializeField] GameObject target;

    [SerializeField] float rotateSpeed;
    float valueAround;

    float fullTour = 360;
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speedRadius, 0);
        value += Time.deltaTime * speedRadius;
        Galaxy();
    }
    void Galaxy()
    {
        if (!this.gameObject.name.Equals("Sun"))
        {
            transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * rotateSpeed);
            valueAround += Time.deltaTime * rotateSpeed;
            if (value + valueAround > fullTour)
            {
                value = 0;
                valueAround = 0;
                Debug.Log(gameObject.name + ": Bir tur tamamlandý.");
            }
        }
        else
        {
            if (value > fullTour)
            {
                value = 0;
                Debug.Log(gameObject.name + ": Bir tur tamamlandý.");
            }
        }
    }
}
