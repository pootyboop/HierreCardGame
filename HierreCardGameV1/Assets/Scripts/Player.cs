using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<CardInformation> hand = new List<CardInformation>();
    Card selectedCard;


    void Start()
    {
    }


    public void SelectCard(Card newSelect)
    {
        SelectCard(newSelect, true);
    }
    public void SelectCard(Card newSelect, bool select)
    {
        if (select)
        {
            SelectCard(selectedCard, false);

            selectedCard = newSelect;
            selectedCard.SetSelected(true);
        }

        else if (selectedCard != null)
        {
            selectedCard.SetSelected(false);
            selectedCard = null;
        }

        GameState.instance.SetPreviewCard(selectedCard);
    }



    public Card GetSelectedCard()
    {
        if (selectedCard == null)
        {
            return null;
        }

        return selectedCard;
    }



    public CardInformation GetSelectedCardInfo()
    {
        if (selectedCard == null)
        {
            return null;
        }

        return selectedCard.cardInfo;
    }
}