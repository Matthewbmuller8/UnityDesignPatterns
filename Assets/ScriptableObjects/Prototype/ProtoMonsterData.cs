using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "NewMonsterData", menuName = "MonsterData")]
public class ProtoMonsterData : ScriptableObject
{
    public int Health;
    public int Damage;
    public string MonsterName;
}
