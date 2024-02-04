using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ECostType
{
    SKULL,  //sacrifice a card
    BONE,   //put one card from Bonepile on bottom of deck
    CARD,   //discard a card
    KNIFE   //take 1 damage
}



[Serializable]
public class CardCost
{
    public ECostType costType;
    public int costAmount;
}
