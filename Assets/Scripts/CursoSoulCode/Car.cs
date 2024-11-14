using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public string color = "red";

    void Start()
    {
        Debug.Log("The color of the car is " + color);
    }
}
