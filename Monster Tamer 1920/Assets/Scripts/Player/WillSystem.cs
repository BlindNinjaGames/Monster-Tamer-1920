using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillSystem : MonoBehaviour
{
    int playerBaseWillPoints = 100;
    public int playerCurrentWillPoints;
   public int playerRank;

    [Tooltip("The number of Will gained from catching monsters")]
    [SerializeField] public int catchWillPoints = 5;

    [Tooltip("The number of Will gained from defeating wild monsters")]
    [SerializeField] public int wildWillPoints = 1;

    [Tooltip("The number of Will gained from defeating trainers/mafia")]
    [SerializeField] public int trainerWillPoints = 10;

    [Tooltip("The number of Will gained from defeating gym leaders")]
    [SerializeField] public int gymWillPoints = 15;

    [Tooltip("The number of Will gained from defeating the elite")]
    [SerializeField] public int eliteWillPoints = 25;

    [Tooltip("The number of Will lost from being defeated")]
    [SerializeField] public int playerDefeatedWillPoints = 10;

    [Tooltip("The number of Will lost from failing to catch a monster")]
    [SerializeField] public int playerFailCatchWillPoints = 5;

    private void Awake()
    {
        playerCurrentWillPoints = playerBaseWillPoints;
    }

    private void Start()
    {
        GetPlayerRank();
    }

   public void GetPlayerRank()
    {
        if(playerCurrentWillPoints < 249)
        {
            playerRank = 1;
        }

        else if(playerCurrentWillPoints >= 250 && playerCurrentWillPoints < 499)
        {
            playerRank = 2;
        }

        else
        {
            playerRank = 3;
        }
    }

}
