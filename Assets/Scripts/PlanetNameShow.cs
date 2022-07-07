using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlanetNameShow : MonoBehaviour
{
    public TMP_Text planetName;
    public Button closeText;
    Vector3 mousePos, lastMousePos;
    void Start()
    {
        
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log(hit.transform.name);
                    planetName.gameObject.SetActive(true);
                    closeText.gameObject.SetActive(true);
                    planetName.text = hit.transform.name;
                }
            }
        }
        //mousePos = ray.direction;
        lastMousePos = Input.mousePosition;
        mousePos = Input.mousePosition - lastMousePos;
        lastMousePos = Input.mousePosition;
        Debug.Log(mousePos);
    }
    public void TextClose()
    {
        planetName.gameObject.SetActive(false); 
        closeText.gameObject.SetActive(false);
    }
}
