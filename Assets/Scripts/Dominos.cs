using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dominos : MonoBehaviour
{
    int massaEsfera = 40;
    void Start()
    {
        if (massaEsfera >= 13 && massaEsfera < 17)
        {
            Debug.Log("Pelo menos 1 domin� caiu da plataforma!");
        } else if (massaEsfera >= 17 && massaEsfera < 27)
        {
            Debug.Log("Pelo menos 2 domin�s cairam da plataforma!");
        } else if (massaEsfera >= 27 && massaEsfera < 39)
        {
            Debug.Log("Os 4 domin�s que est�o de frente para a c�mera ca�ram da plataforma!");
        } else if (massaEsfera >= 39)
        {
            Debug.Log("Tudo caiu da plataforma!");
        } else
        {
            Debug.Log("� preciso aumentar a massa da esfera!");
        }
    }
}
