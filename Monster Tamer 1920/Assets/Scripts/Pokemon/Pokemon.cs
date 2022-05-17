using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [SerializeField] SO_PokemonBase Base { get; set; }
    [SerializeField] int Level { get; set; }

    public int HP { get; set; }

    public List<Move> Moves { get; set; }




    public Pokemon(SO_PokemonBase poBase, int poLevel)
    {
        Base = poBase;
        Level = poLevel;



    Moves = new List<Move>();

        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new Move(move.Base));

            if (Moves.Count >= SO_PokemonBase.MaxNumOfMoves)
                break;
        }
    }

    
    public int GetMonsterRank()
    {
        if (Level <= 4)
        {
           return Base.monsterRank = 1;  //Rank EE
        }

        else if (Level >= 5 && Level <= 8)
        {
           return Base.monsterRank = 2; //Rank ED
        }

        else if (Level >= 9 && Level <=12)
        {
           return Base.monsterRank = 3;  //Rank EC
        }

        else if (Level >= 13 && Level <= 16)
        {
           return Base.monsterRank = 4;  //Rank EB
        }

        else if (Level >= 17 && Level <= 20)
        {
           return Base.monsterRank = 5;  //Rank EA
        }

        else if (Level >= 21 && Level <= 24)
        {
           return Base.monsterRank = 6;  //Rank ES
        }

        else if (Level >= 25 && Level <= 28)
        {
           return Base.monsterRank = 7;  //Rank DE
        }

        else if (Level >= 29 && Level <= 32)
        {
           return Base.monsterRank = 8;  //Rank DD
        }

        else if (Level >= 33 && Level <= 36)
        {
          return Base.monsterRank = 9;  //Rank DC
        }

        else if (Level >= 37 && Level <= 40)
        {
           return Base.monsterRank = 10;  //Rank DB
        }

        else if (Level >= 41 && Level <= 44)
        {
           return Base.monsterRank =11;  //Rank DA
        }

        else if (Level >= 45 && Level <= 48)
        {
           return Base.monsterRank = 12;  //Rank DS
        }

        else if (Level >= 49 && Level <= 52)
        {
           return Base.monsterRank = 13;  //Rank CE
        }

        else if (Level >= 53 && Level <= 56)
        {
           return Base.monsterRank = 14;  //Rank CD
        }

        else if (Level >= 57 && Level <= 60)
        {
           return Base.monsterRank = 15;  //Rank CC
        }

        else if (Level >= 61 && Level <= 64)
        {
           return Base.monsterRank = 16;  //Rank CB
        }

        else if (Level >= 65 && Level <= 68)
        {
           return Base.monsterRank = 17;  //Rank CA
        }

        else if (Level >= 69 && Level <= 72)
        {
           return Base.monsterRank = 18;  //Rank CS
        }

        else if (Level >= 73 && Level <= 76)
        {
           return Base.monsterRank = 19;  //Rank BE
        }

        else if (Level >= 77 && Level <= 80)
        {
           return Base.monsterRank = 20;  //Rank BD
        }

        else if (Level >= 81 && Level <= 84)
        {
           return Base.monsterRank = 21;  //Rank BC
        }

        else if (Level >= 85 && Level <= 88)
        {
           return Base.monsterRank = 22;  //Rank BB
        }

        else if (Level >= 89 && Level <= 92)
        {
           return Base.monsterRank = 23;  //Rank BA
        }

        else if (Level >= 93 && Level <= 96)
        {
           return Base.monsterRank = 24;  //Rank BS
        }

        else if (Level >= 97 && Level <= 100)
        {
           return Base.monsterRank = 25;  //Rank AE
        }

        else if (Level >= 101 && Level <= 104)
        {
           return Base.monsterRank = 26;  //Rank AD
        }

        else if (Level >= 105 && Level <= 108)
        {
           return Base.monsterRank = 27;  //Rank AC
        }

        else if (Level >= 109 && Level <= 112)
        {
           return Base.monsterRank = 28;  //Rank AB
        }

        else if (Level >= 113 && Level <= 116)
        {
           return Base.monsterRank = 29;  //Rank AA
        }

        else if (Level >= 117 && Level <= 120)
        {
           return Base.monsterRank = 30;  //Rank AS
        }

        else if (Level >= 121 && Level <= 124)
        {
           return Base.monsterRank = 31;  //Rank SE
        }

        else if (Level >= 125 && Level <= 128)
        {
           return Base.monsterRank = 32;  //Rank SD
        }

        else if (Level >= 129 && Level <= 132)
        {
           return Base.monsterRank = 33;  //Rank SC
        }

        else if (Level >= 133 && Level <= 136)
        {
           return Base.monsterRank = 34;  //Rank SB
        }

        else if (Level >= 137 && Level <= 149)
        {
           return Base.monsterRank = 35;  //Rank SA
        }

        else
        {
           return Base.monsterRank = 36;  //Rank SS
        }
    }

    

    

}
