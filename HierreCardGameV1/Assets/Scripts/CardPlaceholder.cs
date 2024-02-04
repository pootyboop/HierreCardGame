using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CardPlaceholder : MonoBehaviour
{
    public void OnClicked()
    {
        Player currPlayer = GameState.instance.GetTurnPlayer();
        Card newCard = currPlayer.GetSelectedCard();
        if (newCard == null)
        {
            return;
        }

        newCard.transform.SetParent(transform, false);
        newCard.transform.localPosition = Vector3.zero;

        currPlayer.SelectCard(newCard, false);

        //currPlayer.SelectCard(newCard);
        //newCard.transform.position = new Vector3 (transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
}
