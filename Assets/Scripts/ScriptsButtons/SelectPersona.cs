using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SelectPersona : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image Persona;
    public TextMeshProUGUI txt;
    public GameObject[] character;
    public string texto;
    public static int numPlayer;
    
    void Start(){
        txt.text = "SAMURAI";
    }
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
       numPlayer = 1;
       character[0].SetActive(true);

       if(character[0] == true)
       {
        character[1].SetActive(false);
        character[2].SetActive(false);
        character[3].SetActive(false);
        character[4].SetActive(false);
        character[5].SetActive(false);
        
       }
       
    }
    public void Select2()
    {
        txt.text = texto;
        numPlayer = 2;
        character[1].SetActive(true);
        
        if(character[1] == true)
       {
        character[0].SetActive(false);
        character[2].SetActive(false);
        character[3].SetActive(false);
        character[4].SetActive(false);
        character[5].SetActive(false);
        
       }
    }
    public void Select3()
    {
        txt.text = texto;
        numPlayer = 3;
        character[2].SetActive(true);
        
        if(character[2] == true)
       {
        character[0].SetActive(false);
        character[1].SetActive(false);
        character[3].SetActive(false);
        character[4].SetActive(false);
        character[5].SetActive(false);
        
       }
    }
    public void Select4()
    {
        txt.text = texto;
        numPlayer = 4;
        character[3].SetActive(true);
        
        if(character[3] == true)
       {
        character[0].SetActive(false);
        character[1].SetActive(false);
        character[2].SetActive(false);
        character[4].SetActive(false);
        character[5].SetActive(false);
        
       }
    }

    public void Select5()
    {
        txt.text = texto;
        numPlayer = 5;
        character[4].SetActive(true);
        
        if(character[4] == true)
       {
        character[0].SetActive(false);
        character[1].SetActive(false);
        character[2].SetActive(false);
        character[3].SetActive(false);
        character[5].SetActive(false);
        
       }
    }

     public void Select6()
    {
        txt.text = texto;
        numPlayer = 6;
        character[5].SetActive(true);
        
        if(character[5] == true)
       {
        character[0].SetActive(false);
        character[1].SetActive(false);
        character[2].SetActive(false);
        character[3].SetActive(false);
        character[4].SetActive(false);
        
       }
    }

}
