using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReturn : MonoBehaviour
{
   public void Retornar()
   {
     SceneManager.LoadScene("MenuPrincipal");
   }
}
