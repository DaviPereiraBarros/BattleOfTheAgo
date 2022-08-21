using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ButtonConfirm : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image bttn;

    [SerializeField]  List<DataPersona> priceCharacter = new List<DataPersona>();
    [SerializeField]  List<DataItem> priceItem = new List<DataItem>();
    [SerializeField]  private GameObject[] lockeadCharacter;
    [SerializeField]  private GameObject[] lockeadItem;
    public Text scoreTxt;
    private int score = ManagerCoin.scoreGeral;
    public static int scoreAtual;

    public void OnPointerEnter(PointerEventData eventData)
    {
       bttn.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bttn.color = Color.white;
    }
    void Start(){ 
     scoreTxt.text = score.ToString();
    }
    public void PurchaseCharacter()
    {
       switch(SelectPersona.numPlayer){

        case 1: 
        if( score >= priceCharacter[0].price && SelectPersona.numPlayer == 1){
            scoreAtual = score - priceCharacter[0].price;
            score = scoreAtual;
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;

        case 2: 
       if( score >= priceCharacter[1].price && SelectPersona.numPlayer == 2){
            scoreAtual = score - priceCharacter[1].price;
            score = scoreAtual;
            lockeadCharacter[0].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;
        
        case 3: 
        if( score >= priceCharacter[2].price && SelectPersona.numPlayer == 3){
            scoreAtual = score - priceCharacter[2].price;
            score = scoreAtual;
            lockeadCharacter[1].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;  

        case 4: 
        if( score >= priceCharacter[3].price && SelectPersona.numPlayer == 4){
            scoreAtual = score - priceCharacter[3].price;
            score = scoreAtual;
            lockeadCharacter[2].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;

        case 5:   
        if ( score >= priceCharacter[4].price && SelectPersona.numPlayer == 5){
            scoreAtual = score - priceCharacter[4].price;
            score = scoreAtual;
            lockeadCharacter[3].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break; 

        case 6: 
        if( score >= priceCharacter[5].price && SelectPersona.numPlayer == 6){
            scoreAtual = score - priceCharacter[5].price;
            score = scoreAtual;
            lockeadCharacter[4].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;
       }
    }

    public void PurchaseItens(){
        switch(Select_Item.numItem){

        case 1: 
        if( score >= priceItem[0].priceItem && Select_Item.numItem == 1){
            scoreAtual = score - priceItem[0].priceItem;
            score = scoreAtual;
            lockeadItem[0].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;

        case 2: 
       if( score >= priceItem[1].priceItem && Select_Item.numItem == 2){
            scoreAtual = score - priceItem[1].priceItem;
            score = scoreAtual;
            lockeadItem[1].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;
        
        case 3: 
       if( score >= priceItem[2].priceItem && Select_Item.numItem == 3){
            scoreAtual = score - priceItem[2].priceItem;
            score = scoreAtual;
            lockeadItem[2].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;  

        case 4: 
       if( score >= priceItem[3].priceItem && Select_Item.numItem == 4){
            scoreAtual = score - priceItem[3].priceItem;
            score = scoreAtual;
            lockeadItem[3].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;

        case 5:   
        if( score >= priceItem[4].priceItem && Select_Item.numItem == 5){
            scoreAtual = score - priceItem[4].priceItem;
            score = scoreAtual;
            lockeadItem[4].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break; 

        case 6: 
        if( score >= priceItem[5].priceItem && Select_Item.numItem == 6){
            scoreAtual = score - priceItem[1].priceItem;
            score = scoreAtual;
            lockeadItem[5].SetActive(false);
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
        break;
       }
    }
}
