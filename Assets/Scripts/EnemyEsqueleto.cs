using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEsqueleto : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 1f;
    private Vector3 direcao;
    private bool viradoParaDireita = true;
    void Start()
    {
        direcao = (pontoB.position - pontoA.position).normalized;
    }
    void Update()
    {
        transform.position += direcao * velocidade * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, pontoA.position.y, transform.position.z);

        if (Vector2.Distance(transform.position, pontoB.position) < 1f)
        {
            direcao = (pontoA.position - pontoB.position).normalized;
            Flipar();
        }
        else if (Vector2.Distance(transform.position, pontoA.position) < 0.1f)
        {
            direcao = (pontoB.position - pontoA.position).normalized;
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
}
