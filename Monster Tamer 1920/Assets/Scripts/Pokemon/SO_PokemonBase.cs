using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class SO_PokemonBase : ScriptableObject
{
    [SerializeField] string pokemonName;

    [TextArea]
    [SerializeField] string pokemonDescription;

    [SerializeField]  Sprite pokemonFrontSprite;
    [SerializeField]  Sprite pokemonBackSprite;

    [SerializeField]  SO_TypeBase pokemonType;

    [SerializeField]  int monsterRank;
    [SerializeField]  bool hasNose;


    // Base Stats
    [SerializeField]  int pokemonSpeed;
    [SerializeField]  int pokemonCritical;

    [SerializeField]  List<LearnableMoves> learnableMoves;
    [SerializeField]  List<PokemonStats> pokemonStats;

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

    public void GetMonsterRank(int level)
    {
        if(level <= 4)
        {
           monsterRank = 1;
        }

        else if(level > 4 && level <= 8)
        {
            monsterRank = 2;
        }

        else
        {
            monsterRank = 3;
        }
    }
}

[System.Serializable]
public class LearnableMoves
{
    [SerializeField]  int level;
    [SerializeField]  SO_MoveBase moveBase;

    public SO_MoveBase MoveBase
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}

[System.Serializable]
public class PokemonStats
{
    [SerializeField]  int pokemonLevel;
    [SerializeField]  int pokemonMaxHP;
    [SerializeField]  int pokemonAttack;
    [SerializeField]  int pokemonDefense;
}


public enum Stat
{
    pokemonAttack,
    pokemonDefense,
    pokemonSpeed,
    pokemonCritical,

    // These 2 are not actual stats, they're used to boost the moveAccuracy
    pokemonAccuracy,
    pokemonEvasion

}

public enum GrowthRate
{
    Fast, MediumFast, MediumSlow, Slow, Fluctuating
}