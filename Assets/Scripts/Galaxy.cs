using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptable Object",menuName ="Scriptable Object")]

public class Galaxy : ScriptableObject
{
    public float rotateCamSpeed = 500;
    public int segments = 100;
    public float fullTour = 360;
}
