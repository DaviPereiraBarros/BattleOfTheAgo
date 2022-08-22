using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContinue : MonoBehaviour
{

    void Start()
    {
        Debug.Log(ManagerScene.idScene);
    }
    public void Continue()
    {
        if(ManagerScene.idScene == 1)
        {
            SceneManager.LoadScene("Fase1");
        }
        else if(ManagerScene.idScene == 2){
            SceneManager.LoadScene("Fase2");
        }
        else if(ManagerScene.idScene == 3){
            SceneManager.LoadScene("Fase_Final");
        }
    }
}
