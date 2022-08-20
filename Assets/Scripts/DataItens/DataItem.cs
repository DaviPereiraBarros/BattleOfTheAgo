using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Item")]
public class DataItem : ScriptableObject
{
    public float lifeItem;
    public int priceItem;
    public int danoItem;
    public int shieldItem;
    public float manaItem;

}
