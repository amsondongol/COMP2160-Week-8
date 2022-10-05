using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PlayerAxis
{
    public string horizontalAxis;
    public string verticalAxis;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private PlayerMovement playerPrefab;
    [SerializeField] private int playerCount = 2;
    [SerializeField] private PlayerAxis[] playerAxis;
    [SerializeField] private Vector3[] spawnPositions;

    private List<PlayerMovement> players = new List<PlayerMovement>();

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        for (int i = 0; i < playerCount; i++)
        {
            PlayerMovement newPlayer = Instantiate(playerPrefab);
            if (spawnPositions.Length > 0)
            {
                newPlayer.transform.position = spawnPositions[i % (spawnPositions.Length)];
            }

            newPlayer.SetPlayerType(i, playerAxis[i]);

            players.Add(newPlayer);
        }

        Scorekeeper.instance.UpdatePlayerScores(players.Count);
    }

    public bool IsValidPlayer(int index)
    {
        return index >= 0 && index < players.Count;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmos()
    {
        if (spawnPositions != null && spawnPositions.Length > 0)
        {
            Gizmos.color = Color.red;
            for (int i = 0; i < spawnPositions.Length; i++)
            {
                Gizmos.DrawSphere(spawnPositions[i], 0.05f);
            }
        }
    }
}
