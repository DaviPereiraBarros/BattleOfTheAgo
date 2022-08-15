using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisibleData : MonoBehaviour
{
    public DataPersona data;
    public TextMeshProUGUI[] text;

    void Start()
    {
        text[0].text = "Life : " + data.life.ToString();
        text[1].text = "Dano : " + data.dano.ToString();
        text[2].text = "Shield : " + data.shield.ToString();
        text[3].text = "Mana : " + data.mana.ToString();
    }

    
    void Update()
    {
        
    }
}
