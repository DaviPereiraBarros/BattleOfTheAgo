using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGoIn : MonoBehaviour
{
    public void GoIn()
    {
        SceneManager.LoadScene("SceneStore");
    }
}
