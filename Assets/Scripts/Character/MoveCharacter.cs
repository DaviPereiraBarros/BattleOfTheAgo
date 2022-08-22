using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public Rigidbody2D player;
    public Animator CharacterAnim;
    public Vector2 direcao;
    public float walkSpeed;
    public float runSpeed;
    public float jumpSpeed;
    private float moveSpeed;
    private bool  gira;
    private bool dChao;
    private bool puloDuplo;
    private float yAtual;
    private float yMax;

    void Start()
    {
        direcao =  new Vector2(0,0);

        yAtual = 0;
        yMax = -100;
    }

    
    void Update()
    {
        player = GetComponent<Rigidbody2D>();

        VerificarY();

        LeituraTeclado();
        
        Animacao(direcao);

        DirecaoMovimento();
        
    }

    void LeituraTeclado()
    {
      if(Input.GetKeyDown(KeyCode.Space) && dChao == true)
      {
       player.velocity = new Vector2(player.velocity.x, jumpSpeed); 
       direcao =  new Vector2(0,1);
       puloDuplo = true;
      }

      if(Input.GetKeyDown(KeyCode.Space) && dChao == false && puloDuplo == true)
      {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed); 
        direcao =  new Vector2(0,1);
        puloDuplo = false;
      }

      if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
      {
        player.velocity = new Vector2(-moveSpeed, player.velocity.y);    
        gira = true;

        if(dChao)
        {
          direcao =  new Vector2(-1,0);
        }
      }

      if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
      {
         player.velocity = new Vector2(moveSpeed, player.velocity.y);
         gira = false;

        if(dChao)
        {
          direcao =  new Vector2(1,0);
        }
      }

      if(Input.GetKey(KeyCode.LeftShift))
      {
        moveSpeed = runSpeed;
      }
      else
      {
        moveSpeed = walkSpeed;
      }
    }

     void Animacao(Vector2 dir)
  {
    CharacterAnim.SetFloat("X", dir.x);
    CharacterAnim.SetFloat("Y", dir.y);
  }

  void DirecaoMovimento()
   {
     
     if(gira)
     { 
       transform.rotation = new Quaternion(0,180,0,0);        
     }
     else
     {
       transform.rotation = new Quaternion(0,0,0,0);
     }
   }

   private void OnCollisionStay2D(Collision2D other) 
{
  if(other.gameObject.CompareTag("Chao"))
  {
    dChao = true;
   
  }
  
}

private void OnCollisionExit2D(Collision2D other) 
{
  if(other.gameObject.CompareTag("Chao"))
  {
    dChao = false;
  }
  
}

void VerificarY()
 {
  yAtual = transform.position.y;

  if(dChao == true)
  {
    direcao = new Vector2(0,0);
    yMax = -100;
  }

  if(yAtual > yMax)
  {
    yMax = yAtual;
  }

  if((yAtual == yMax) &&  dChao == false)
  {
    direcao = new Vector2 (0,1);       
  }

  if((yAtual != yMax) && dChao == false)
  {
    direcao = new Vector2 (0,-1);           
  }
 }

}
