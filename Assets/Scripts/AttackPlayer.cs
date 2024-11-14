using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttackPlayer : MonoBehaviour
{
    // public AttackEnemy enemyScript;
    public int playerHealth = 100;
    public Slider lifeSlider;
    public Text textUI;
    public Animator animator;

    public int maxHealth = 100;
    public Transform respawnPoint;
    public float respawnDelay = 0.5f;
    public int maxRespawns = 3;
    private int respawnCount = 0;
    public bool isDead = false;

    void Update()
    {
        lifeSlider.value = playerHealth * 0.01f;
        textUI.text = (maxRespawns - respawnCount).ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Attack(collision.gameObject);
        }
    }


    public void Attack(GameObject enemy)
    {
        // enemyScript = FindFirstObjectByType<AttackEnemy>();

        AttackEnemy enemyScript = enemy.GetComponentInChildren<AttackEnemy>();
        enemyScript.EnemyTakeDamage(10);
    }

    public void PlayerTakeDamage(int damage)
    {
        playerHealth -= damage;
        Debug.Log("Você levou " + damage + " de dano! " + "Saúde restante: " + playerHealth);

        if (playerHealth <= 0)
        {
            Debug.Log("Player morreu!");
            isDead = true;
            animator.SetTrigger("Death");
            if (respawnCount < maxRespawns)
            {
                respawnCount++;
                StartCoroutine(Respawn());
            }
            else
            {
                GameOver();
            }
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnDelay);

        transform.parent.position = respawnPoint.position;
        transform.parent.rotation = respawnPoint.rotation;

        playerHealth = maxHealth;
        isDead = false;

        Debug.Log("Player renasceu com " + playerHealth + " de vida.");
    }

    void GameOver()
    {
        Debug.Log("Game Over! Carregando nova cena!");
        SceneManager.LoadScene(0);
    }

}
