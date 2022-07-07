using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlanetNameShow : MonoBehaviour
{
    public TMP_Text planetName;
    public Button closeText;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    Debug.Log(hit.transform.name);
                    planetName.gameObject.SetActive(true); 
                    closeText.gameObject.SetActive(true);
                    planetName.text = hit.transform.name;
                }
            }
        }
    }
    public void TextClose()
    {
        planetName.gameObject.SetActive(false); 
        closeText.gameObject.SetActive(false);
    }
}
