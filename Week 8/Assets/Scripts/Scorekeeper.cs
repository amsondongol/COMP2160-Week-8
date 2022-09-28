using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    public static Scorekeeper instance;
    [SerializeField] private int pointsPerPickup;

    public int Score
    {
        get
        {
            return score;
        }
    }
    private int score;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void IncreaseScore(int add)
    {
        score += add;
    }

    public void Pickup()
    {
        score += pointsPerPickup;
    }
}
