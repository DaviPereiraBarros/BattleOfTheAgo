using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] List<DataItem> itens = new List<DataItem>();
    [SerializeField] List<DataPersona> data = new List<DataPersona>();
    public TextMeshProUGUI[] text;
    public float lifeTotal;
    public int priceTotal;
    public int danoTotal;
    public int shieldTotal;
    public float manaTotal;
    
    public void Start(){
        
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
    void Update()
    {
        SamuraiMaisItem();
        KnightMaisItem();
        KillerMaisItem();
        HeroMaisItem();
        TankMaisItem();
        MageMaisItem();
    }

    private void SamuraiMaisItem(){
        
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem ==1){
        lifeTotal = data[0].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[0].dano + itens[0].danoItem;
        shieldTotal = data[0].shield + itens[0].shieldItem;
        manaTotal = data[0].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem ==2){
        lifeTotal = data[0].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[0].dano + itens[1].danoItem;
        shieldTotal = data[0].shield + itens[1].shieldItem;
        manaTotal = data[0].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem == 3){
        lifeTotal = data[0].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[0].dano + itens[2].danoItem;
        shieldTotal = data[0].shield + itens[2].shieldItem;
        manaTotal = data[0].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem == 4){
        lifeTotal = data[0].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[0].dano + itens[3].danoItem;
        shieldTotal = data[0].shield + itens[3].shieldItem;
        manaTotal = data[0].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem == 5){
        lifeTotal = data[0].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[0].dano + itens[4].danoItem;
        shieldTotal = data[0].shield + itens[4].shieldItem;
        manaTotal = data[0].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 1 && Select_Item.numItem == 6){
        lifeTotal = data[0].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[0].dano + itens[5].danoItem;
        shieldTotal = data[0].shield + itens[5].shieldItem;
        manaTotal = data[0].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
    }
    private void KnightMaisItem(){
     
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem ==1){
        lifeTotal = data[1].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[1].dano + itens[0].danoItem;
        shieldTotal = data[1].shield + itens[0].shieldItem;
        manaTotal = data[1].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem ==2){
        lifeTotal = data[1].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[1].dano + itens[1].danoItem;
        shieldTotal = data[1].shield + itens[1].shieldItem;
        manaTotal = data[1].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem == 3){
        lifeTotal = data[1].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[1].dano + itens[2].danoItem;
        shieldTotal = data[1].shield + itens[2].shieldItem;
        manaTotal = data[1].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem == 4){
        lifeTotal = data[1].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[1].dano + itens[3].danoItem;
        shieldTotal = data[1].shield + itens[3].shieldItem;
        manaTotal = data[1].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem == 5){
        lifeTotal = data[1].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[1].dano + itens[4].danoItem;
        shieldTotal = data[1].shield + itens[4].shieldItem;
        manaTotal = data[1].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 2 && Select_Item.numItem == 6){
        lifeTotal = data[1].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[1].dano + itens[5].danoItem;
        shieldTotal = data[1].shield + itens[5].shieldItem;
        manaTotal = data[1].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
      }
    private void KillerMaisItem(){
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem ==1){
        lifeTotal = data[2].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[2].dano + itens[0].danoItem;
        shieldTotal = data[2].shield + itens[0].shieldItem;
        manaTotal = data[2].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem ==2){
        lifeTotal = data[2].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[2].dano + itens[1].danoItem;
        shieldTotal = data[2].shield + itens[1].shieldItem;
        manaTotal = data[2].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem == 3){
        lifeTotal = data[2].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[2].dano + itens[2].danoItem;
        shieldTotal = data[2].shield + itens[2].shieldItem;
        manaTotal = data[2].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem == 4){
        lifeTotal = data[2].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[2].dano + itens[3].danoItem;
        shieldTotal = data[2].shield + itens[3].shieldItem;
        manaTotal = data[2].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem == 5){
        lifeTotal = data[2].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[2].dano + itens[4].danoItem;
        shieldTotal = data[2].shield + itens[4].shieldItem;
        manaTotal = data[2].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 3 && Select_Item.numItem == 6){
        lifeTotal = data[2].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[2].dano + itens[5].danoItem;
        shieldTotal = data[2].shield + itens[5].shieldItem;
        manaTotal = data[2].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
    } 
    private void HeroMaisItem(){
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem ==1){
        lifeTotal = data[3].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[3].dano + itens[0].danoItem;
        shieldTotal = data[3].shield + itens[0].shieldItem;
        manaTotal = data[3].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem ==2){
        lifeTotal = data[3].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[3].dano + itens[1].danoItem;
        shieldTotal = data[3].shield + itens[1].shieldItem;
        manaTotal = data[3].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem == 3){
        lifeTotal = data[3].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[3].dano + itens[2].danoItem;
        shieldTotal = data[3].shield + itens[2].shieldItem;
        manaTotal = data[3].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem == 4){
        lifeTotal = data[3].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[3].dano + itens[3].danoItem;
        shieldTotal = data[3].shield + itens[3].shieldItem;
        manaTotal = data[3].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem == 5){
        lifeTotal = data[3].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[3].dano + itens[4].danoItem;
        shieldTotal = data[3].shield + itens[4].shieldItem;
        manaTotal = data[3].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 4 && Select_Item.numItem == 6){
        lifeTotal = data[3].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[3].dano + itens[5].danoItem;
        shieldTotal = data[3].shield + itens[5].shieldItem;
        manaTotal = data[3].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
    }
    private void TankMaisItem(){
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem ==1){
        lifeTotal = data[4].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[4].dano + itens[0].danoItem;
        shieldTotal = data[4].shield + itens[0].shieldItem;
        manaTotal = data[4].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem ==2){
        lifeTotal = data[4].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[4].dano + itens[1].danoItem;
        shieldTotal = data[4].shield + itens[1].shieldItem;
        manaTotal = data[4].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem == 3){
        lifeTotal = data[4].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[4].dano + itens[2].danoItem;
        shieldTotal = data[4].shield + itens[2].shieldItem;
        manaTotal = data[4].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem == 4){
        lifeTotal = data[4].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[4].dano + itens[3].danoItem;
        shieldTotal = data[4].shield + itens[3].shieldItem;
        manaTotal = data[4].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem == 5){
        lifeTotal = data[4].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[4].dano + itens[4].danoItem;
        shieldTotal = data[4].shield + itens[4].shieldItem;
        manaTotal = data[4].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 5 && Select_Item.numItem == 6){
        lifeTotal = data[4].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[4].dano + itens[5].danoItem;
        shieldTotal = data[4].shield + itens[5].shieldItem;
        manaTotal = data[4].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
    }
    private void MageMaisItem(){
        switch(Select_Item.numItem){
        
        case 1:    
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem ==1){
        lifeTotal = data[5].life + itens[0].lifeItem;
        priceTotal = itens[0].priceItem;
        danoTotal = data[5].dano + itens[0].danoItem;
        shieldTotal = data[5].shield + itens[0].shieldItem;
        manaTotal = data[5].mana + itens[0].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        }
        break;

        case 2:
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem ==2){
        lifeTotal = data[5].life + itens[1].lifeItem;
        priceTotal = itens[1].priceItem;
        danoTotal = data[5].dano + itens[1].danoItem;
        shieldTotal = data[5].shield + itens[1].shieldItem;
        manaTotal = data[5].mana + itens[1].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 3:
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem == 3){
        lifeTotal = data[5].life + itens[2].lifeItem;
        priceTotal = itens[2].priceItem;
        danoTotal = data[5].dano + itens[2].danoItem;
        shieldTotal = data[5].shield + itens[2].shieldItem;
        manaTotal = data[5].mana + itens[2].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 4:
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem == 4){
        lifeTotal = data[5].life + itens[3].lifeItem;
        priceTotal = itens[3].priceItem;
        danoTotal = data[5].dano + itens[3].danoItem;
        shieldTotal = data[5].shield + itens[3].shieldItem;
        manaTotal = data[5].mana + itens[3].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 5:
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem == 5){
        lifeTotal = data[5].life + itens[4].lifeItem;
        priceTotal = itens[4].priceItem;
        danoTotal = data[5].dano + itens[4].danoItem;
        shieldTotal = data[5].shield + itens[4].shieldItem;
        manaTotal = data[5].mana + itens[4].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        case 6:
        
        if(SelectPersona.numPlayer == 6 && Select_Item.numItem == 6){
        lifeTotal = data[5].life + itens[5].lifeItem;
        priceTotal = itens[5].priceItem;
        danoTotal = data[5].dano + itens[5].danoItem;
        shieldTotal = data[5].shield + itens[5].shieldItem;
        manaTotal = data[5].mana + itens[5].manaItem;

        text[0].text = "Life : " + lifeTotal.ToString();
        text[1].text = "Dano : " + danoTotal.ToString();
        text[2].text = "Shield : " + shieldTotal.ToString();
        text[3].text = "Mana : " + manaTotal.ToString();
        text[4].text = "Price : " + priceTotal.ToString();
        } 
        break;

        }
    }
}
