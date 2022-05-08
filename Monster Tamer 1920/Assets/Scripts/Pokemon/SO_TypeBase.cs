using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type Effectiveness", menuName = "Types/Create new attack type")]
public class SO_TypeBase : ScriptableObject
{
    [SerializeField] string typeName;

    [Tooltip("The elemental type that will be super effective against the opponent.")]
    [SerializeField] List<SO_TypeBase> superEffective = new List<SO_TypeBase>();

    [Tooltip("The elemental type that will be weak against the opponent.")]
    [SerializeField] List<SO_TypeBase> notVeryEffective = new List<SO_TypeBase>();

    [Tooltip("The elemental type that will buff the opponent.")]
    [SerializeField] List<SO_TypeBase> buffPokemon = new List<SO_TypeBase>();
}