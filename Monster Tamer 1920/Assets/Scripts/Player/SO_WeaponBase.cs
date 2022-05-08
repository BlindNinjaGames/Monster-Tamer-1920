using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Player/Create new weapon")]
public class SO_WeaponBase : ScriptableObject
{
    [SerializeField] string weaponName;

    [TextArea]
    [SerializeField] string weaponDescription;

    [SerializeField] Sprite weaponFrontSprite;
    [SerializeField] Sprite weaponBackSprite;

    [SerializeField] SO_TypeBase weaponType;

    [SerializeField] List<WeaponStats> weaponStats;

}

[System.Serializable]
public class WeaponStats
{
    [SerializeField] int weaponLevel;
    [SerializeField] int weaponAttack;
    [SerializeField] int weaponCritical;
    [SerializeField] int weaponDefense;
}
