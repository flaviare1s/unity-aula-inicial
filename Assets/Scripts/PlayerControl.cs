using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    public Transform verificadorDeChao;
    public LayerMask camadaDoChao;
    private bool estaNoChao;
    private Rigidbody2D rb;
    private bool viradoParaDireita = true;
    public Animator animator;
    public AudioSource attackSound;
    public AudioSource stepSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isRuning", false);
        animator.SetBool("isJumping", false);
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Pular();
        Virar();
        Attack();
    }

    void Mover()
    {
        float entradaMovimento = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(entradaMovimento * velocidade, rb.velocity.y);

        float deadZone = 0.1f;
        bool isRuning = Mathf.Abs(entradaMovimento) > deadZone;
        animator.SetBool("isRuning", isRuning);

        if (isRuning)
        {
            if (!stepSound.isPlaying)
            {
                stepSound.Play();
            }
        }
        else 
        {
            if (stepSound.isPlaying)
            {
                stepSound.Stop();
            }
        }
    }

    void Pular()
    {
        estaNoChao = Physics2D.OverlapCircle(verificadorDeChao.position, 0.2f, camadaDoChao);

        if(estaNoChao) {
            animator.SetBool("isJumping", false);
        }

        if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
            animator.SetBool("isJumping", true);
        }

        if (!estaNoChao) {
            stepSound.Stop();
        }
    }

    void Virar()
    {
        float entradaMovimento = Input.GetAxis("Horizontal");

        if (entradaMovimento > 0 && !viradoParaDireita)
        {
            Flipar();
        } else if (entradaMovimento < 0 && viradoParaDireita)
        {
            Flipar();
        }

    }

    void Flipar()
    {
        viradoParaDireita = !viradoParaDireita;
        Vector3 escalaLocal = transform.localScale;
        escalaLocal.x *= -1;
        transform.localScale = escalaLocal;
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Attack");
            attackSound.Play();
        }
    }
}
