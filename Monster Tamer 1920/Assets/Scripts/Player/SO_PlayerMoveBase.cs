using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerMove", menuName = "Player/Create new move")]
public class SO_PlayerMoveBase : ScriptableObject
{
    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string moveDescription;

    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] bool alwaysHits;
    [SerializeField] int pp;
    [SerializeField] int priority;

    [SerializeField] MoveCategory category;
    [SerializeField] MoveEffects effects;
    [SerializeField] List<SecondaryEffects> secondaries;
    [SerializeField] MoveTarget target;

}

[System.Serializable]
public class PlayerMoveEffects
{
    [SerializeField] List<StatBoost> boosts;
    //  [SerializeField] ConditionID status;
    // [SerializeField] ConditionID volatileStatus;
}

[System.Serializable]
public class PlayerSecondaryEffects : MoveEffects
{
    [SerializeField] int chance;
    [SerializeField] MoveTarget target;
}

[System.Serializable]
public class PlayerStatBoost
{
    public Stat stat;
    public int boost;
}

public enum PlayerMoveCategory
{
    Physical, Special, Status
}

public enum PlayerMoveTarget
{
    Foe, Self
}