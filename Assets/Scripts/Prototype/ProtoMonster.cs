using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoMonster : MonoBehaviour
{
    [SerializeField]
    public ProtoMonsterData MonsterData;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintData();
        }
    }

    private void PrintData()
    {
        string message = $"{MonsterData.MonsterName} has {MonsterData.Health} health and {MonsterData.Damage} damage.";
        Debug.Log(message);
    }
}
