using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public Card cardPrefab, previewCard;
    public TMPro.TextMeshProUGUI abilitiesInfo;

    public static GameState instance;
    public Player[] players = new Player[2];
    public int playerTurnIndex = 0;

    void Start()
    {
        instance = this;
        SetupPlayers();
    }



    void SetupPlayers()
    {
        players[0] = new Player();
        players[1] = new Player();
    }



    public Player GetTurnPlayer()
    {
        return players[playerTurnIndex];
    }



    public Card InstantiateCard(CardInformation cardInformation)
    {
        Card newCard = Instantiate(cardPrefab);
        newCard.SetInformation(cardInformation);
        return newCard;
    }



    public void SetPreviewCard(Card card)
    {
        if (card == null)
        {
            previewCard.gameObject.SetActive(false);

            SetAbilitiesInfo(null);
        }

        else
        {
            previewCard.gameObject.SetActive(true);
            previewCard.SetInformation(card.cardInfo);
            SetAbilitiesInfo(card.cardInfo);
        }
    }



    void SetAbilitiesInfo(CardInformation cardInfo)
    {
        if (cardInfo == null)
        {
            abilitiesInfo.text = string.Empty;
            return;
        }

        string newText = "";

        foreach (CardAbility ability in cardInfo.abilities)
        {
            newText += "\n<color=#CC00CC>" + ability.ability + "<color=#FFFFFF>: <color=#DDDDDD>" + AbilityInfoManager.instance.GetAbilityDesc(ability.ability);
        }

        abilitiesInfo.text = newText;
    }
}