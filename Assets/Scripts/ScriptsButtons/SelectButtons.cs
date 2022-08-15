using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class SelectButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image Persona;
    public TextMeshProUGUI txt;
    public GameObject[] player;
    public string texto;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Persona.color = Color.green;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Persona.color = Color.black;
    }

    public void Select() 
    {
       txt.text = texto;
    }
}
