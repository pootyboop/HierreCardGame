using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum EOrigin
{
    VOENN,
    RONETTO,
    YUETTA,
    IRSEN,
    PRIEDENNE,
    LUNSCU,
    GURESSEN
}



public enum ESeries
{
    ONE,
    TWO
}



[CreateAssetMenu(fileName = "Data", menuName = "CARDS/New Card", order = 1)]
[Serializable]
public class CardInformation : ScriptableObject
{
    public String name;
    public CardCost[] cost;
    public CardAbility[] abilities;
    public int power, health;
    public EOrigin[] origins;
    public ESeries series;
}
