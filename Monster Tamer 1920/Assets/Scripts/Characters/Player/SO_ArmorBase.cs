using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Player/Create new armor")]
public class SO_ArmorBase : ScriptableObject
{
    [SerializeField] string armorName;

    [TextArea]
    [SerializeField] string armorDescription;

    [SerializeField] Sprite armorFrontSprite;
    [SerializeField] Sprite armorBackSprite;

    [SerializeField] SO_TypeBase armorType;

    [SerializeField] List<ArmorStats> armorStats;

}


[System.Serializable]
public class ArmorStats
{
    [SerializeField] int armorLevel;
    [SerializeField] int armorDefense;
}
