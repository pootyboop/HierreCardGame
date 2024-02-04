using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ECardAbility
{
    MOVE,
    ATTACK,
    DRAW,
    LEAPING
}



[CreateAssetMenu(fileName = "Data", menuName = "CARDS/New Ability Info", order = 1)]
[Serializable]
public class AbilityInformation : ScriptableObject
{
    public ECardAbility ability;
    public string desc;
}
