using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstro : MonoBehaviour
{
    bool fugiram = true;
    void Start()
    {
        string resultado = fugiram ? "Voltem aqui!" : "Oi, meu nome � Bubbles";
        Debug.Log(resultado);
    }

}
