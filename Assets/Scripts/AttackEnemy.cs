using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour
{
    public Animator animator;
    public int enemyHealth = 50;
    private bool enemyInRange = false;
    private bool hasAttacked = false;
    public AttackPlayer playerScript;
    public Slider lifeSlider;
    void Update()
    {
        if (enemyInRange && !hasAttacked)
        {
            Attack();
        }
        lifeSlider.value = enemyHealth * 0.01f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemyInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemyInRange = false;
            hasAttacked = false;
        }
    }

    public void Attack()
    {
        playerScript = FindFirstObjectByType<AttackPlayer>();
        playerScript.PlayerTakeDamage(20);
        animator.SetTrigger("Attack");
        hasAttacked = true;
    }

    public void EnemyTakeDamage(int damage)
    {
        enemyHealth -= damage;
        Debug.Log(". Inimigo levou " + damage + " de dano!" + " Saúde restante: " + enemyHealth);
        if (enemyHealth <= 0)
        {
            animator.SetTrigger("Death");
            Destroy(transform.parent.gameObject, 1f);
        }
    }
}
