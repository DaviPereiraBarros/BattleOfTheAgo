using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static Life instance;

    public DataPersona datas;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

    }
    public float LifeGlobal;

    void Start()
    {
        LifeGlobal = datas.life;
    }

}