using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAdventure : MonoBehaviour
{
   
    public void SceneTransition()
    {
        SceneManager.LoadScene("SceneFases");
    }
}
