using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ButtonConfirm : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image bttn;
    public void Confirm()
    {
        if(SelectPersona.numPlayer != 0)
        {
            SceneManager.LoadSceneAsync("Cena1");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       bttn.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bttn.color = Color.black;
    }

}
