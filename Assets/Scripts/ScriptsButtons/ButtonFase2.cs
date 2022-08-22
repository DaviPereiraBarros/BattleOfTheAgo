using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFase2 : MonoBehaviour
{
     public void Fase2()
    {
         ManagerScene.idScene = 2;
        SceneManager.LoadScene("SceneTransition");
    }
}
