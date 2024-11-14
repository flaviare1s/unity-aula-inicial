using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    void Start()
    {   // If-else
        int numero = 10;
        if (numero > 0)
        {
            Debug.Log("O n�mero � positivo");
        } else
        {
            Debug.Log("O n�mero � negativo");
        }

        // If-elseif-else
        int temperatura = 30;
        if (temperatura > 30)
        {
            Debug.Log("Est� muito quente!");
        } else if (temperatura < 10)
        {
            Debug.Log("Est� muito frio!");
        } else
        {
            Debug.Log("A temperatura est� agrad�vel!");
        }

        // Mais exemplos
        int idade = 18;
        if (idade >= 18)
        {
            Debug.Log("Voc� � maior de idade!");
        } else
        {
            Debug.Log("Voc� � menor de idade!");
        }

        string diaDaSemana = "Sexta";
        if (diaDaSemana == "S�bado" ||  diaDaSemana == "Domingo")
        {
            Debug.Log("Hoje � dia de descansar!");
        } else
        {
            Debug.Log("Hoje � dia de trabalhar!");
        }

        // Operador tern�rio
        int numeroAlunos = 10;
        string resultado = (numeroAlunos >= 10) ? "Turma cheia!" : "Ainda tem vaga!";
        Debug.Log(resultado);

        bool estaAprovado = true;
        string status = estaAprovado ? "Aprovado!" : "Reprovado!";
        Debug.Log(status);

        // Switch-case
        int nivel = 2;
        switch (nivel)
        {
            case 1:
                Debug.Log("voc� est� no n�vel 1");
                break;
            case 2:
                Debug.Log("Voc� est� no n�vel 2");
                break;
            case 3:
                Debug.Log("Voc� est� no n�vel 3");
                break;
            default:
                Debug.Log("N�vel desconhecido!");
                break;
        }

        string cor = "amarelo";
        switch (cor)
        {
            case "vermelho":
                Debug.Log("A cor � vermelho");
                break;
            case "azul":
                Debug.Log("A cor � azul");
                break;
            case "verde":
                Debug.Log("A cor � verde");
                break;
            default:
                Debug.Log("Cor n�o conhecida");
                break;
        }
    }
}
