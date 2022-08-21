using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChallenge : MonoBehaviour
{
    public void Challenge()
    {
        SceneManager.LoadScene("Challenge");
    }
}
