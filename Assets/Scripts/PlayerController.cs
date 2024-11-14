using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;
    public Animator playerAnimator;
    bool isWalking;
    public AudioSource attackSound;
    public AudioSource stepSound;
    public AttackPlayer attackScript;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        attackScript = FindObjectOfType<AttackPlayer>();

        if(attackScript.isDead)
        {
            stepSound.Stop();
            attackSound.Stop();
            rb.velocity = Vector2.zero;
        }

        // Aqui as coisas começam a acontecer:

        if (!attackScript.isDead)
        {
            float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
            float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
            isWalking = eixoX != 0 || eixoY != 0;
            rb.velocity = new Vector2(eixoX, eixoY);

            if (isWalking)
            {
                playerAnimator.SetFloat("eixoX", eixoX);
                playerAnimator.SetFloat("eixoY", eixoY);

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
            playerAnimator.SetBool("isWalking", isWalking);

            if (Input.GetButtonDown("Fire1"))
            {
                playerAnimator.SetTrigger("Attack");
                attackSound.Play();
            }

        }
        // Aqui encerram as coisas.
    }
}
