using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonItem_Character : MonoBehaviour
{
    [SerializeField] private GameObject canvaInven;

    [SerializeField] private GameObject canvaCharacter;
    void Start()
    {
        
    }

    
    void Update()
    {
    
    }

    public void Inven(){
        canvaInven.SetActive(true);
        Select_Item.numItem = 0;
        canvaCharacter.SetActive(false);
    }

    public void Character(){
        canvaCharacter.SetActive(true);
        canvaInven.SetActive(false);
    }
}
