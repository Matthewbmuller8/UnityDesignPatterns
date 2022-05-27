using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class contains the shared data that will be referenced by other object instances
[System.Serializable]
public class Flyweight
{
    [HideInInspector]
    public Material SharedMaterial { get; private set; }
    [HideInInspector]
    public Material AltMaterial { get; private set; }

    public Flyweight(Material matOne, Material matTwo)
    {
        SharedMaterial = matOne;
        AltMaterial = matTwo;
    }

    public void SwapMaterial()
    {
        if (SharedMaterial != null && AltMaterial != null)
        {
            Material temp = SharedMaterial;
            SharedMaterial = AltMaterial;
            AltMaterial = temp;
        } else
        {
            Debug.Log("No material assigned");
        }
    }
}
