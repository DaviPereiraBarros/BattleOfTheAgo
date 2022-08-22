using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour
{
    public void Back(string backScene)
    {
       SceneManager.LoadScene(backScene);
    }
}
