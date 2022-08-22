using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFase1 : MonoBehaviour
{
    public void Fase1()
    {
        ManagerScene.idScene = 1;
        SceneManager.LoadScene("SceneTransition");
    }
}
