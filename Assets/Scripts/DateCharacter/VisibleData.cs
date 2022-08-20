using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisibleData : MonoBehaviour
{
    [SerializeField] List<DataPersona> data = new List<DataPersona>();
    public TextMeshProUGUI[] text;

    void Start()
    {
      if(SelectPersona.numPlayer == 0){
        text[0].text = "Life : " + data[0].life.ToString();
        text[1].text = "Dano : " + data[0].dano.ToString();
        text[2].text = "Shield : " + data[0].shield.ToString();
        text[3].text = "Mana : " + data[0].mana.ToString();
        }
    }

    
    void Update()
    {
        if(SelectPersona.numPlayer == 1){
        text[0].text = "Life : " + data[0].life.ToString();
        text[1].text = "Dano : " + data[0].dano.ToString();
        text[2].text = "Shield : " + data[0].shield.ToString();
        text[3].text = "Mana : " + data[0].mana.ToString();
        text[4].text = "Price : " + data[0].price.ToString();
        }
        else if(SelectPersona.numPlayer == 2){
        text[0].text = "Life : " + data[1].life.ToString();
        text[1].text = "Dano : " + data[1].dano.ToString();
        text[2].text = "Shield : " + data[1].shield.ToString();
        text[3].text = "Mana : " + data[1].mana.ToString();
        text[4].text = "Price : " + data[1].price.ToString();
        }
        else if(SelectPersona.numPlayer == 3){
        text[0].text = "Life : " + data[2].life.ToString();
        text[1].text = "Dano : " + data[2].dano.ToString();
        text[2].text = "Shield : " + data[2].shield.ToString();
        text[3].text = "Mana : " + data[2].mana.ToString();
        text[4].text = "Price : " + data[2].price.ToString();
        }
        else if(SelectPersona.numPlayer == 4){
        text[0].text = "Life : " + data[3].life.ToString();
        text[1].text = "Dano : " + data[3].dano.ToString();
        text[2].text = "Shield : " + data[3].shield.ToString();
        text[3].text = "Mana : " + data[3].mana.ToString();
        text[4].text = "Price : " + data[3].price.ToString();
        }
        else if(SelectPersona.numPlayer == 5){
        text[0].text = "Life : " + data[4].life.ToString();
        text[1].text = "Dano : " + data[4].dano.ToString();
        text[2].text = "Shield : " + data[4].shield.ToString();
        text[3].text = "Mana : " + data[4].mana.ToString();
        text[4].text = "Price : " + data[4].price.ToString();
        }
        else if(SelectPersona.numPlayer == 6){
        text[0].text = "Life : " + data[5].life.ToString();
        text[1].text = "Dano : " + data[5].dano.ToString();
        text[2].text = "Shield : " + data[5].shield.ToString();
        text[3].text = "Mana : " + data[5].mana.ToString();
        text[4].text = "Price : " + data[5].price.ToString();
        }
    }

    public static void DataCharacter()
    {

    }
}
