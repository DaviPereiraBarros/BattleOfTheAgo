using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconInventory : MonoBehaviour
{
    [SerializeField] private GameObject[] iconsImage;




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void IconsInventory()
    {
       switch(SelectPersona.numPlayer)
        {
            case 1:
            if(SelectPersona.numPlayer == 1 && ManagerCoin.scoreGeral != 1500){

                iconsImage[0].SetActive(true);
            } 

            break;
        }
    }
}
