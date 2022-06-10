using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObserver : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(SingletonGameManager.Instance.GetLevelNumber());
        }
    }
}
