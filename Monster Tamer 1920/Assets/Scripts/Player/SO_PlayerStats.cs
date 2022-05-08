using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Player/Create new stats")]

public class SO_PlayerStats : ScriptableObject
{
    [SerializeField] List<PlayerStats> playerStats;
}

[System.Serializable]
public class PlayerStats
{
    [SerializeField] int level;
    [SerializeField] int playerMaxHP;
    [SerializeField] int playerAttack;
    [SerializeField] int playerDefense;
}