using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoMonster : MonoBehaviour
{
    public int Health;
    public int Damage;
    public string Name;

    public void Init (int health, int damage, string name)
    {
        Health = health;
        Damage = damage;
        Name = name;
    }
}
