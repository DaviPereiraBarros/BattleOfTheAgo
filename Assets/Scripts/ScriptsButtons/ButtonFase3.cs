using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFase3 : MonoBehaviour
{
     public void Fase3()
    {
        ManagerScene.idScene = 3;
        SceneManager.LoadScene("SceneTransition");
    }
}
