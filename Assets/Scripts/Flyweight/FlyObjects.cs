using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyObjects : MonoBehaviour
{
    private FlyGameManager gameManager;
    private Renderer objRend;

    void Start()
    {
        gameManager = FlyGameManager.Instance;
        objRend = GetComponent<Renderer>();
        //This object doesn't need a material, because it is stored in the game manager
        UpdateMaterial();
        //Need to add the material update function to the game manager event
        gameManager.MatSwap += UpdateMaterial;
    }

    //Updates to the new shared material when it is changed
    private void UpdateMaterial()
    {
        objRend.material = gameManager.sharedData.SharedMaterial;
    }
}
