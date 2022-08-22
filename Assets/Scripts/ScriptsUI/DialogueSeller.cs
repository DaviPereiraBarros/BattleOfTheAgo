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

    [SerializeField] private Text dialogueTxt;

    [SerializeField] private GameObject boxDialogue;
    public float distance;
    public float time = 0;
    public string[] dialogue;
    
    void Start()
    {
       
    }

   
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);

        if(distance <= 1.8f)
        {
            cam.orthographicSize -= 0.2f;
            if(cam.orthographicSize <= 4f)
            {
                boxDialogue.SetActive(true);
                cam.orthographicSize = 4f;
                time += 0.2f;
                dialogueTxt.text = dialogue[0];
                Repeat();
            }
        }
    }

    void Repeat()
    {
        if(time >= 5){
        dialogueTxt.text = dialogue[1];
        }

        if(time >= 10){
        time = 10f;
        dialogueTxt.text = dialogue[2];
        }
    }

}
