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

        // Init();
    }

}
