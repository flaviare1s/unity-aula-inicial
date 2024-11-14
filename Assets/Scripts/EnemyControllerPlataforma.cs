// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class EnemyController1 : MonoBehaviour
// {
//     public PlayerControl1 _playerScript;
//     private Rigidbody2D _rb;
//     private Animator _animator;
//     private AudioSource _audioSource;
//     public List<Transform> _wayPoints;
//     public bool _hasAttacked;
//     public float _velocidade = 2f;
//     int _proximoPonto = 0;
//     public int _enemyHealth;

//     void Start()
//     {
//         _rb = GetComponent<Rigidbody2D>();
//         _audioSource = GetComponent<AudioSource>();
//         _animator = GetComponent<Animator>();
//     }

//     void Update()
//     {
//         if (_wayPoints.Count > 0)
//         {
//             Vector2 direcao = (_wayPoints[_proximoPonto].position - transform.position).normalized;
//             _rb.velocity = direcao * _velocidade;

//             if (Vector2.Distance(transform.position, _wayPoints[_proximoPonto].position) < 0.1f)
//             {
//                 _proximoPonto = (_proximoPonto + 1) % _wayPoints.Count;

//                 if (transform.localScale.x == -1) transform.localScale = new Vector2(1f, transform.localScale.y);
//                 else transform.localScale = new Vector2(-1f, transform.localScale.y);
//             }
//         }
//     }

//     public void EnemyTakeDamage(int damage)
//     {
//         _enemyHealth -= damage;
//         Debug.Log("Inimigo tomou " + damage + " de dano. Saúde restante: " + _enemyHealth);

//         if (_enemyHealth <= 0)
//         {
//             Destroy(transform.parent.gameObject);
//         }
//     }

//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         if (collision.gameObject.name == "Player")
//         {
//             Debug.Log("Player entrou na zona de combate!");
//             _playerScript = FindFirstObjectByType<PlayerControl1>();
//             _playerScript.PlayerTakeDamage(10);
//             _animator.SetTrigger("attack");
//             //_audioSource.Play();
//             _hasAttacked = true;
//         }
//     }

//     private void OnTriggerExit2D(Collider2D collision)
//     {
//         if (collision.CompareTag("Player"))
//         {
//             Debug.Log("Player saiu da zona de combate!");
//             _hasAttacked = false;
//         }
//     }
// }
