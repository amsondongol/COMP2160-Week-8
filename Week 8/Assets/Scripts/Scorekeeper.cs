using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    public static Scorekeeper instance;
    [SerializeField] private int pointsPerPickup;

    private int[] scores = new int[0];

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void IncreaseScore(int add, int playerIndex)
    {
        if (GameManager.instance.IsValidPlayer(playerIndex))
        {
            scores[playerIndex] += add;
        }
    }

    public void Pickup(int playerIndex)
    {
        IncreaseScore(pointsPerPickup, playerIndex);
    }

    public void UpdatePlayerScores(int playerCount)
    {
        int[] newScores = new int[playerCount];
        for (int i = 0; i < scores.Length; i++)
        {
            newScores[i] = scores[i];
        }

        scores = new int[playerCount];
        for (int i = 0; i < playerCount - 1; i++)
        {
            scores[i] = newScores[i];
        }
    }

    public int GetScore(int playerIndex)
    {
        return GameManager.instance.IsValidPlayer(playerIndex) ? scores[playerIndex] : 0;
    }
}
