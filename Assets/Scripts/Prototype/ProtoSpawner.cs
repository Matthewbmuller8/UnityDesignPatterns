using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoSpawner : MonoBehaviour
{
    public GameObject MonsterPrototypeObj;
    public ProtoMonsterData MonsterPrototypeData;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMonster(MonsterPrototypeObj);
        }
    }

    public void SpawnMonster(GameObject monsterProto)
    {
        //Create the new monster object in world space - state is stored in Scriptable Object
        Instantiate(monsterProto, transform.position, Quaternion.identity).GetComponent<ProtoMonster>().MonsterData = MonsterPrototypeData;
    }
}
