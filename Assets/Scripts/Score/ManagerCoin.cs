using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCoin : MonoBehaviour
{
    public static int scoreGeral = 1500;
    public Text txtScore;
    
    void Start()
    {
        txtScore.text = scoreGeral.ToString();
    }

   
    void Update()
    {
        if(scoreGeral < ButtonConfirm.scoreAtual)
        {
            scoreGeral = ButtonConfirm.scoreAtual;
            txtScore.text = scoreGeral.ToString();
        }
    }
}
