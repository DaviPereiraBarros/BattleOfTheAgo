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
    public Text score;
    public string scoreTxt;
    public int scoreAtual;

    public void OnPointerEnter(PointerEventData eventData)
    {
       bttn.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bttn.color = Color.white;
    }

    void Start(){

        scoreAtual = int.Parse(score.text.ToString());
    }

    public void PurchaseCharacter()
    {
       switch(scoreAtual){

        case 1: 
        if( scoreAtual >= priceCharacter[2].price && SelectPersona.numPlayer == 3 ){
            scoreTxt = priceCharacter[0].price.ToString();
            scoreAtual -= int.Parse(scoreTxt);
            score.text = scoreAtual.ToString();
            Debug.Log("Hay");
        }
        break;

        case 2: 
        if( scoreAtual >= priceCharacter[1].price){
            scoreAtual -= priceCharacter[1].price;
            score.text = scoreAtual.ToString();
        }
        break;
        
        case 3: 
        if( scoreAtual >= priceCharacter[2].price){
            scoreAtual -= priceCharacter[2].price;
            score.text = scoreAtual.ToString();
        }
        break;  

        case 4: 
        if( scoreAtual >= priceCharacter[3].price){
            scoreAtual -= priceCharacter[3].price;
            score.text = scoreAtual.ToString();
        }
        break;   

        case 5: 
        if( scoreAtual >= priceCharacter[4].price){
            scoreAtual -= priceCharacter[4].price;
            score.text = scoreAtual.ToString();
        }
        break; 

        case 6: 
        if( scoreAtual >= priceCharacter[5].price){
            scoreAtual -= priceCharacter[5].price;
            score.text = scoreAtual.ToString();
        }
        break;
       }
    }

}
