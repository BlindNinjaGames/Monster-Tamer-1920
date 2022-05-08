using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player/Create new player")]
public class SO_PlayerBase : ScriptableObject
{
    [SerializeField] string playerName;

    [TextArea]
    [SerializeField] string playerDescription;

    [SerializeField] bool isPlayer;

    [SerializeField] SO_ArmorBase playerArmor;
    [SerializeField] SO_WeaponBase playerWeapon;
    [SerializeField] SO_PlayerStats playerStats;

    // Base Stats
    [SerializeField] int playerSpeed;

    [SerializeField] List<PlayerLearnableMoves> playerLearnableMoves;

    [SerializeField] int expYield;
    [SerializeField] GrowthRate growthRate;


    public static int MaxNumOfMoves { get; set; } = 4;

    public int GetExpForLevel(int level)
    {
        if (growthRate == GrowthRate.Fast)
        {
            return 4 * (level * level * level) / 5;
        }
        else if (growthRate == GrowthRate.MediumFast)
        {
            return level * level * level;
        }

        else if (growthRate == GrowthRate.MediumSlow)
        {
            return 6 * (level * level * level) / 5 - 15 * (level * level) + 100 * level - 140;
        }
        else if (growthRate == GrowthRate.Slow)
        {
            return 5 * (level * level * level) / 4;
        }
        else if (growthRate == GrowthRate.Fluctuating)
        {
            return GetFluctuating(level);
        }

        return -1;
    }

    // Created a new method for getting the fluctuating levels
    public int GetFluctuating(int level)
    {
        if (level < 15)
        {
            return Mathf.FloorToInt(Mathf.Pow(level, 3) * ((Mathf.Floor((level + 1) / 3) + 24) / 50));
        }
        else if (level >= 15 && level < 36)
        {
            return Mathf.FloorToInt(Mathf.Pow(level, 3) * ((level + 14) / 50));
        }
        else
        {
            return Mathf.FloorToInt(Mathf.Pow(level, 3) * ((Mathf.Floor(level / 2) + 32) / 50));
        }
    }

    public int ExpYield => expYield;

    public GrowthRate GrowthRate => growthRate;
}

[System.Serializable]
public class PlayerLearnableMoves
{
    [SerializeField] int level;
    [SerializeField] SO_PlayerMoveBase playerMoveBase;
}


public enum PlayerStat
{
    playerMaxHP,
    playerAttack,
    playerDefense,
    playerSpeed,
    playerCritical,

    // These 2 are not actual stats, they're used to boost the moveAccuracy
    playerAccuracy,
    playerEvasion
}
