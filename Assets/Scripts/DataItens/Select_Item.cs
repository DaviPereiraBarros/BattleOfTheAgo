using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Select_Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image Fundo;
    public TextMeshProUGUI txtItem;
    public string texto;
    public static int numItem;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Fundo.color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Fundo.color = Color.black;
    }

    public void Sword(){
        txtItem.text = texto;
        numItem = 1;
    }

    public void Shadow(){
        txtItem.text = texto;
        numItem = 2;
    }

    public void Arm(){
        txtItem.text = texto;
        numItem = 3;
    }

    public void Unshakable(){
        txtItem.text = texto;
        numItem = 4;
    }

    public void Accessories(){
        txtItem.text = texto;
        numItem = 5;
    }

    public void Potion(){
        txtItem.text = texto;
        numItem = 6;
    }

}