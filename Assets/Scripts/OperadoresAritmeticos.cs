using System;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresAritmeticos : MonoBehaviour
{
    int a = 10;
    int b = 3;
    float c = 3.4f;

    void Start()
    {
        Debug.Log("Soma (a + b): " + (a + b));
        Debug.Log("Subtra��o (a - b): " + (a - b));
        Debug.Log("Multiplica��o (a * b): " + (a * b));
        Debug.Log("Divis�o (a / b): " + (a / b));
        Debug.Log("Resto da Divis�o (a % b): " + (a % b));

        // Convers�o impl�cita:
        float novo_b = b;
        Debug.Log(novo_b);


        // Comvers�o expl�cita:
        int novo_c = (int)c;
        Debug.Log(novo_c);

        // Convers�o de string:
        string numeroString = "100";
        int numeroInt = Convert.ToInt32(numeroString);
        int numeroInt2 = int.Parse(numeroString);
        Debug.Log(numeroString);
        Debug.Log(numeroInt);
        Debug.Log(numeroInt2);
        Debug.Log("Tipo de dado: " + numeroString.GetType());

    }
}
