using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    private float celsius;

    public float Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }
    void Start()
    {
        Celsius = 25;
        Debug.Log("Celsius: " + Celsius + " Fahrenheit: " + toFahrenheit(Celsius));
    }

    float toFahrenheit(float celsius)
    {
        return (Celsius * 9 / 5) + 32;
    }
}
