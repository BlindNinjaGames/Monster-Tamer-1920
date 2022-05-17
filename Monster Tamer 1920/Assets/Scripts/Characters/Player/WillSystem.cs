using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillSystem : MonoBehaviour
{
    int playerBaseWillPoints = 100;
    public int playerCurrentWillPoints = 100;
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

    

    private void Start()
    {
        GetPlayerRank();
    }

   public void GetPlayerRank()
    {
        if(playerCurrentWillPoints < 249)
        {
            playerRank = 1;  //Rank EE
        }

        else if(playerCurrentWillPoints >= 250 && playerCurrentWillPoints <= 499)
        {
            playerRank = 2;  //Rank ED
        }

        else if (playerCurrentWillPoints >= 500 && playerCurrentWillPoints <= 749)
        {
            playerRank = 3;  //Rank EC
        }

        else if (playerCurrentWillPoints >= 750 && playerCurrentWillPoints <= 999)
        {
            playerRank = 4;  //Rank EB
        }

        else if (playerCurrentWillPoints >= 1000 && playerCurrentWillPoints <= 1499)
        {
            playerRank = 5;  //Rank EA
        }

        else if (playerCurrentWillPoints >= 1500 && playerCurrentWillPoints <= 1999)
        {
            playerRank = 6; //Rank ES
        }

        else if (playerCurrentWillPoints >= 2000 && playerCurrentWillPoints <= 2249)
        {
            playerRank = 7;  //Rank DE
        }

        else if (playerCurrentWillPoints >= 2250 && playerCurrentWillPoints <= 2499)
        {
            playerRank = 8;  //Rank DD
        }

        else if (playerCurrentWillPoints >= 2500 && playerCurrentWillPoints <= 2749)
        {
            playerRank = 9;  //Rank DC
        }

        else if (playerCurrentWillPoints >= 2750 && playerCurrentWillPoints <= 2999)
        {
            playerRank = 10;  //Rank DB
        }

        else if (playerCurrentWillPoints >= 3000 && playerCurrentWillPoints <= 3499)
        {
            playerRank = 11;  //Rank DA
        }

        else if (playerCurrentWillPoints >= 3500 && playerCurrentWillPoints <= 3999)
        {
            playerRank = 12;  //Rank DS
        }

        else if (playerCurrentWillPoints >= 4000 && playerCurrentWillPoints <= 4249)
        {
            playerRank = 13;  //Rank CE
        }

        else if (playerCurrentWillPoints >= 4250 && playerCurrentWillPoints <= 4499)
        {
            playerRank = 14;  //Rank CD
        }

        else if (playerCurrentWillPoints >= 4500 && playerCurrentWillPoints <= 4749)
        {
            playerRank = 15;  //Rank CC
        }

        else if (playerCurrentWillPoints >= 4750 && playerCurrentWillPoints <= 4999)
        {
            playerRank = 16;  //Rank CB
        }

        else if (playerCurrentWillPoints >= 5000 && playerCurrentWillPoints <= 5499)
        {
            playerRank = 17;  //Rank CA
        }

        else if (playerCurrentWillPoints >= 5500 && playerCurrentWillPoints <= 5999)
        {
            playerRank = 18;  //Rank CS
        }

        else if (playerCurrentWillPoints >= 6000 && playerCurrentWillPoints <= 6249)
        {
            playerRank = 19;  //Rank BE
        }

        else if (playerCurrentWillPoints >= 6250 && playerCurrentWillPoints <= 6499)
        {
            playerRank = 20;  //Rank BD
        }

        else if (playerCurrentWillPoints >= 6500 && playerCurrentWillPoints <= 6749)
        {
            playerRank = 21;  //Rank BC
        }

        else if (playerCurrentWillPoints >= 6750 && playerCurrentWillPoints <= 6999)
        {
            playerRank = 22;  //Rank BB
        }

        else if (playerCurrentWillPoints >= 7000 && playerCurrentWillPoints <= 7499)
        {
            playerRank = 23;  //Rank BA
        }

        else if (playerCurrentWillPoints >= 7500 && playerCurrentWillPoints <= 7999)
        {
            playerRank = 24;  //Rank BS
        }

        else if (playerCurrentWillPoints >= 8000 && playerCurrentWillPoints <= 8249)
        {
            playerRank = 25;  //Rank AE
        }

        else if (playerCurrentWillPoints >= 8250 && playerCurrentWillPoints <= 8499)
        {
            playerRank = 26;  //Rank AD
        }

        else if (playerCurrentWillPoints >= 8500 && playerCurrentWillPoints <= 8749)
        {
            playerRank = 27;  //Rank AC
        }

        else if (playerCurrentWillPoints >= 8750 && playerCurrentWillPoints <= 8999)
        {
            playerRank = 28;  //Rank AB
        }

        else if (playerCurrentWillPoints >= 9000 && playerCurrentWillPoints <= 9499)
        {
            playerRank = 29;  //Rank AA
        }

        else if (playerCurrentWillPoints >= 9500 && playerCurrentWillPoints <= 9999)
        {
            playerRank = 30;  //Rank AS
        }

        else if (playerCurrentWillPoints >= 10000 && playerCurrentWillPoints <= 10999)
        {
            playerRank = 31;  //Rank SE
        }

        else if (playerCurrentWillPoints >= 11000 && playerCurrentWillPoints <= 11999)
        {
            playerRank = 32;  //Rank SD
        }

        else if (playerCurrentWillPoints >= 12000 && playerCurrentWillPoints <= 12999)
        {
            playerRank = 33;  //Rank SC
        }

        else if (playerCurrentWillPoints >= 13000 && playerCurrentWillPoints <= 13999)
        {
            playerRank = 34;  //Rank SB
        }

        else if (playerCurrentWillPoints >= 14000 && playerCurrentWillPoints <= 14999)
        {
            playerRank = 35;  //Rank SA
        }

        else
        {
            playerRank = 36;  //Rank SS
        }
    }

}
