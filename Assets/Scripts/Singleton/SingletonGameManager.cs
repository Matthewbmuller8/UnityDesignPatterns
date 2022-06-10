using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManager : MonoBehaviour
{
    public static SingletonGameManager Instance { get; private set; }

    private int levelNumber = 1;

    private void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        } else
        {
            Instance = this;
        }
    }

    public int GetLevelNumber()
    {
        return levelNumber;
    }
}
