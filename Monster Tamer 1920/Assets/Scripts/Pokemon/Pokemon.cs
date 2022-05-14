using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [SerializeField] SO_PokemonBase _base;
    [SerializeField] int level;

    public Pokemon(SO_PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
    }

    public SO_PokemonBase Base
    {
        get
        {
            return _base;
        }
    }
    public int Level
    {
        get
        {
            return level;
        }
    }


    /*
    public int GetMonsterRank(int level)
    {
        if (level <= 4)
        {
           return monsterRank = 1;  //Rank EE
        }

        else if (level >= 5 && level <= 8)
        {
           return monsterRank = 2; //Rank ED
        }

        else if (level >= 9 && level <=12)
        {
           return monsterRank = 3;  //Rank EC
        }

        else if (level >= 13 && level <= 16)
        {
           return monsterRank = 4;  //Rank EB
        }

        else if (level >= 17 && level <= 20)
        {
           return monsterRank = 5;  //Rank EA
        }

        else if (level >= 21 && level <= 24)
        {
           return monsterRank = 6;  //Rank ES
        }

        else if (level >= 25 && level <= 28)
        {
           return monsterRank = 7;  //Rank DE
        }

        else if (level >= 29 && level <= 32)
        {
           return monsterRank = 8;  //Rank DD
        }

        else if (level >= 33 && level <= 36)
        {
          return monsterRank = 9;  //Rank DC
        }

        else if (level >= 37 && level <= 40)
        {
           return monsterRank = 10;  //Rank DB
        }

        else if (level >= 41 && level <= 44)
        {
           return monsterRank =11;  //Rank DA
        }

        else if (level >= 45 && level <= 48)
        {
           return monsterRank = 12;  //Rank DS
        }

        else if (level >= 49 && level <= 52)
        {
           return monsterRank = 13;  //Rank CE
        }

        else if (level >= 53 && level <= 56)
        {
           return monsterRank = 14;  //Rank CD
        }

        else if (level >= 57 && level <= 60)
        {
           return monsterRank = 15;  //Rank CC
        }

        else if (level >= 61 && level <= 64)
        {
           return monsterRank = 16;  //Rank CB
        }

        else if (level >= 65 && level <= 68)
        {
           return monsterRank = 17;  //Rank CA
        }

        else if (level >= 69 && level <= 72)
        {
           return monsterRank = 18;  //Rank CS
        }

        else if (level >= 73 && level <= 76)
        {
           return monsterRank = 19;  //Rank BE
        }

        else if (level >= 77 && level <= 80)
        {
           return monsterRank = 20;  //Rank BD
        }

        else if (level >= 81 && level <= 84)
        {
           return monsterRank = 21;  //Rank BC
        }

        else if (level >= 85 && level <= 88)
        {
           return monsterRank = 22;  //Rank BB
        }

        else if (level >= 89 && level <= 92)
        {
           return monsterRank = 23;  //Rank BA
        }

        else if (level >= 93 && level <= 96)
        {
           return monsterRank = 24;  //Rank BS
        }

        else if (level >= 97 && level <= 100)
        {
           return monsterRank = 25;  //Rank AE
        }

        else if (level >= 101 && level <= 104)
        {
           return monsterRank = 26;  //Rank AD
        }

        else if (level >= 105 && level <= 108)
        {
           return monsterRank = 27;  //Rank AC
        }

        else if (level >= 109 && level <= 112)
        {
           return monsterRank = 28;  //Rank AB
        }

        else if (level >= 113 && level <= 116)
        {
           return monsterRank = 29;  //Rank AA
        }

        else if (level >= 117 && level <= 120)
        {
           return monsterRank = 30;  //Rank AS
        }

        else if (level >= 121 && level <= 124)
        {
           return monsterRank = 31;  //Rank SE
        }

        else if (level >= 125 && level <= 128)
        {
           return monsterRank = 32;  //Rank SD
        }

        else if (level >= 129 && level <= 132)
        {
           return monsterRank = 33;  //Rank SC
        }

        else if (level >= 133 && level <= 136)
        {
           return monsterRank = 34;  //Rank SB
        }

        else if (level >= 137 && level <= 149)
        {
           return monsterRank = 35;  //Rank SA
        }

        else
        {
           return monsterRank = 36;  //Rank SS
        }
    }

    */

    

}
