using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 100;

    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    void Damage (int damageAmount)
    {
        Health -= damageAmount;
        Debug.Log("Current Health: " + Health);
    }

    void Start()
    {
        Damage(10);
    }
}
