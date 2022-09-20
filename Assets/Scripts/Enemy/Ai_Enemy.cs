using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private BoxCollider2D danoCollider;

    public Animator enemyAnim;
    
    public float speed;

    public float dist;

    public int lifeEnemy;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        lifeEnemy = 50;
    }

    void Update()
    {
        Detect();
        Follow();
    }

    void Detect()
    {
        float diferencaParaJogador = transform.position.x - target.transform.position.x; 
        if(diferencaParaJogador > 0)
        {
            transform.rotation = new Quaternion(0,180,0,0);
        }
        else
        {
            transform.rotation = new Quaternion(0,0,0,0);
        }
    }

    void Follow()
    {
        float distancia = Vector2.Distance(transform.position, target.position);

        if(distancia > dist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            enemyAnim.SetBool("Walking", true);
        }

        if(distancia < 1.5f)
        {
            enemyAnim.SetBool("Attack", true);
            danoCollider.enabled = true;
        }
        else
        {
            enemyAnim.SetBool("Attack", false);
            danoCollider.enabled = false;
        }
    }

        void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.CompareTag("Attack"))
        {
            Debug.Log("Ativo");
            /*lifeEnemy -= 10;

            if(lifeEnemy <= 0)
            {
                Destroy(gameObject);   
            }*/
        } 
        
      }
    
    
}



