using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGameManager : MonoBehaviour
{
    public Flyweight sharedData;
    [SerializeField]
    private Material redMat;
    [SerializeField]
    private Material greenMat;

    public delegate void SwapEvent();
    public event SwapEvent MatSwap;

    //Singleton setup
    public static FlyGameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        //Make in awake before all the objects update their material
        sharedData = new Flyweight(redMat, greenMat);
    }

    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sharedData.SwapMaterial();
            MatSwap?.Invoke();
        }
    }
}
