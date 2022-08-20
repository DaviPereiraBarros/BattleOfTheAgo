using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Character")]
public class DataPersona : ScriptableObject
{
    public float life;
    public float speed;
    public int price;
    public int dano;
    public int shield;
    public float mana;
    public GameObject persona;

}
