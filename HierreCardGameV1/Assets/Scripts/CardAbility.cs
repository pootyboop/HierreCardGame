using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum EDirection
{
    N,
    S,
    E,
    W,
    NW,
    SW,
    NE,
    SE
}



[Serializable]
public class CardAbility
{
    public ECardAbility ability;
    public int level;
    public EDirection[] directions;
}
