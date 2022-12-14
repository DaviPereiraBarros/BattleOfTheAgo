using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carregamento : MonoBehaviour
{
    public string cenaACarregar;
    public float TempoFixoSeg = 0;
    public enum TipoCarreg{Carregament, TempoFixo,}
    public TipoCarreg tipoDeCarregamento;
    public Image barraDeCarregamento;
    public Text TextoProgresso;
    private int progresso = 0;
    private string textoOriginal;
   
    void Start()
    {   
       progresso = 0; 
       StartCoroutine(Tempo(cenaACarregar));
        
        switch (tipoDeCarregamento)
        {
           case TipoCarreg.Carregament:
           StartCoroutine(Cena(cenaACarregar));
           break;
           
           case TipoCarreg.TempoFixo:
           StartCoroutine(Tempo(cenaACarregar));
           break;
        }

        if(TextoProgresso != null)
        {
        textoOriginal = TextoProgresso.text;
        }

        if(barraDeCarregamento != null)
        {
       barraDeCarregamento.type = Image.Type.Filled;
       barraDeCarregamento.fillMethod = Image.FillMethod.Horizontal;
       barraDeCarregamento.fillOrigin = (int) Image.OriginHorizontal.Left;
        }
    }

    IEnumerator Cena(string cena)
    {
        AsyncOperation carregamento = SceneManager.LoadSceneAsync(cena);

        while(!carregamento.isDone)
        {
            progresso = (int) (carregamento.progress * 100.0f);
            yield return null;
        }
    }

    IEnumerator Tempo(string cena)
    {
        yield return new WaitForSeconds(TempoFixoSeg);
        SceneManager.LoadScene(cena);
    }

    
    void Update()
    {


        switch (tipoDeCarregamento)
        {
           case TipoCarreg.Carregament:
           break;

           case TipoCarreg.TempoFixo:
           progresso = (int)(Mathf.Clamp((Time.time/TempoFixoSeg),0.0f,1.0f) * 100.0f);
           break;  
        }
        
        if(TextoProgresso != null)
        {
           TextoProgresso.text = " " + progresso + "%";
        }

        if(barraDeCarregamento != null)
        {
          barraDeCarregamento.fillAmount = (progresso/ 100.0f);       
        }
        
        
    }
}
