using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueSeller : MonoBehaviour
{
    [SerializeField] private Transform seller;

    [SerializeField] private Transform player;

    [SerializeField] private Camera cam;

    [SerializeField] private Text dialogue;

    [SerializeField] private GameObject boxDialogue;

    public float distance;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);

        if(distance <= 1.2f)
        {
            cam.orthographicSize -= 0.2f;

            if(cam.orthographicSize <= 4f)
            {
                boxDialogue.SetActive(true);
                cam.orthographicSize = 4f;
                dialogue.fontSize = 22;
            }
        }
    }
}
