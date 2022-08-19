using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public Image barraDeCarregamento;
    private float progresso = 0;
    private float progAtual;
    void Start()
    {
        progresso = 0;
        progAtual = Random.Range(2,5);
    }

    void Update()
    {
        progresso += 0.5f * Time.deltaTime;

        if(progresso >= progAtual)
        {
          SceneManager.LoadScene("MenuPrincipal");
        }

        if(barraDeCarregamento != null)
        {
          barraDeCarregamento.fillAmount = (progresso/2);       
        }
    }

     
}