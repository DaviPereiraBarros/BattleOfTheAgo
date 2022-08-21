using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D player;
    public Animator playerAnim;
    public Vector2 direcao;
    private Vector3 posInicial;
    //public Image barraVida;
    public float walkSpeed, runSpeed, jumpSpeed;
    private float moveSpeed;
    public bool gira;
    private bool dChao;
    private bool puloDuplo;
    private float YAtual;
    private float YMax;
    private bool Running;
    public float vidaPlayer;
    
    void Start()
    {
        direcao = new Vector2(0, 0);

        YAtual = 0;
        YMax = -100;

        posInicial = transform.position;
    }

    void Update()
    {
        player = GetComponent<Rigidbody2D>();

        playerAnim = GetComponent<Animator>();

        VerificarY();

        LeituraTeclado();

        DirecaoMovimento();

        Animacao(direcao);

        Morte();

        /*if (liberacor == true)
        {
            PingPong(8);
        }
        if (DanoCritico == true)
        {
            PingPong(1);
        }*/

    }

    void LeituraTeclado()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dChao == true)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            direcao = new Vector2(0, 1);
            puloDuplo = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && dChao == false && puloDuplo == true)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            direcao = new Vector2(0, 1);
            puloDuplo = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.velocity = new Vector2(-moveSpeed, player.velocity.y);
            gira = true;
            if (dChao)
            {
                direcao = new Vector2(-1, 0);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector2(moveSpeed, player.velocity.y);
            gira = false;
            if (dChao)
            {
                direcao = new Vector2(1, 0);
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
            playerAnim.SetBool("Running", true);


        }

        else
        {
            moveSpeed = walkSpeed;
            playerAnim.SetBool("Running", false);

        }
    }

    void Animacao(Vector2 dir)
    {
        playerAnim.SetFloat("X", dir.x);
        playerAnim.SetFloat("Y", dir.y);
        
    }


    void DirecaoMovimento()
    {
        if (gira)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

        else
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            dChao = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Chao"))
        {
            dChao = false;
        }
    }

    /*public void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("inimigo"))
        {
            vidaPlayer -= 5;
            barraVida.fillAmount = vidaPlayer / 100;
        }


    }*/

    void VerificarY()
    {
        YAtual = transform.position.y;
        if (dChao == true)
        {
            direcao = new Vector2(0, 0);
            YMax = -100;
        }

        if (YAtual > YMax)
        {
            YMax = YAtual;
        }

        if ((YAtual == YMax) && dChao == false)
        {
            direcao = new Vector2(0, 1);
        }

        if ((YAtual != YMax) && dChao == false)
        {
            direcao = new Vector2(0, -1);
        }
    }

    /*void Dano()
    {
        liberacor = true;
        StartCoroutine(LiberaCor());
    }*/

    /*void PingPong(int x)
    {
        personagem.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(x * Time.time, 1.5f));
    }*/

    


    /*IEnumerator LiberaCor()
    {
        yield return new WaitForSeconds(0.5f);
        liberacor = false;
        personagem.color = new Color(1, 1, 1, 1);
    }*/

    private void Morte()
    {
        if (vidaPlayer <= 0 )
        {
            playerAnim.SetTrigger("Morte");
            
        }
    }
}
   


