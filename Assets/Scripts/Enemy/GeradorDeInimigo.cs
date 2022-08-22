using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigo : MonoBehaviour
{
    public Transform inimigoPrefab;

    public float GeradorRate = 2f;

    public float MaxInimigo;

    
    void Start()
    {
        InvokeRepeating("GeradorInimigo", GeradorRate, GeradorRate);
        MaxInimigo = 4;
        
        
    }

    private void GeradorInimigo()
    {
         var inimigoTransform = Instantiate(inimigoPrefab) as Transform;
        inimigoTransform.position = transform.position;
        inimigoTransform.rotation = new Quaternion(0, 0, 0, 0);

        MaxInimigo -= 1;
        if (MaxInimigo <= 0)
        {
            Destroy(gameObject);
        }
    }



    
}
