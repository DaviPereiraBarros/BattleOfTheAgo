using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;

    void Awake(){
         
        if (instance == null)
        {
            instance = this;

        }
    }
    public Image lifeBar;
    public Animator animHud;
    public DataPersona datas;
    public GameObject GameOver;
    public GameObject Canva;
    public float life;
    public float mana;
    public int dano;


    void Start()
    {
        life = datas.life;

        mana = datas.mana;

        dano = datas.dano;
    }


    void Update()
    {
  
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Inimigo"))
        {
            life -= 4;
            lifeBar.fillAmount = life/100;

            if(life <= 0)
            {
                GameOver.SetActive(true);
                Canva.SetActive(false);
            }
        } 
    } 

}

