using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private int score = 0;

    public int Score
    {
        get { return score; }
    }
    void Start()
    {
        Player2 player = new Player2();
        player.AddScore(10);
        Debug.Log("Score: " + player.Score);
    }

    void AddScore(int points)
    {
        score += points;
    }
}
