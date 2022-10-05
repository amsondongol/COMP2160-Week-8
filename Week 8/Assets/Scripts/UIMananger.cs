using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMananger : MonoBehaviour
{
    public static UIMananger instance;

    [SerializeField] private TextMeshProUGUI[] playerScoreTexts;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < playerScoreTexts.Length; i++)
        {
            playerScoreTexts[i].text = $"SCORE:  {Scorekeeper.instance.GetScore(i)}";
        }
    }
}
