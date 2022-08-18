using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstTouch : MonoBehaviour
{   
    public GameObject text;
    
    public GameObject load;

    void Start()
    {
        text.SetActive(true);
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            text.SetActive(false);
            load.SetActive(true);
        }
    }
}
