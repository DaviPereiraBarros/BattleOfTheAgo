using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Item")]
public class DataItem : ScriptableObject
{
    public float life;
    public float speed;
    public int dano;
    public int shield;
    public float mana;
    public GameObject persona;

}
