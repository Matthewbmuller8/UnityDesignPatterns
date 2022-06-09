using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoSpawner : MonoBehaviour
{
    public GameObject MonsterPrototypeObj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMonster(MonsterPrototypeObj);
        }
    }

    public void SpawnMonster(GameObject monsterProto)
    {
        //Create the new monster object in world space - this should share state with the prototype
        Instantiate(monsterProto, transform.position, Quaternion.identity);
    }
}
