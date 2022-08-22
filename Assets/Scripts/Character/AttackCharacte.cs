using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCharacte : MonoBehaviour
{
   public Animator animAttk;
   public BoxCollider2D boxCollider2D;
    void Start()
    {
    
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.C))
      {
        animAttk.SetBool("Attack1", true);
        boxCollider2D.enabled = true;
      }
      else
      {
        animAttk.SetBool("Attack1", false);
        boxCollider2D.enabled = false;
      }

      if(Input.GetKey(KeyCode.V))
      {
        animAttk.SetBool("Attack2", true);
        boxCollider2D.enabled = true;
      }
      else
      {
        animAttk.SetBool("Attack2", false);
        boxCollider2D.enabled = false;
      }   

    }
}
