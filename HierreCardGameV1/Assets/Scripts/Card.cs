using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardInformation cardInfo;
    public TMPro.TextMeshProUGUI name, abilities, powerHealth;
    public Button button;

    public bool selected = false;

    public Image bg;
    private Color bgColor;
    public Color bgSelectedColor;

    public bool isPreview = false;



    void Start()
    {
        bgColor = bg.color;

        if (isPreview)
        {
            Destroy(button.gameObject);
            //button.enabled = false;
        }

        if (cardInfo != null )
        {
            SetInformation(cardInfo);
        }
    }



    public void OnClick()
    {
        GameState.instance.GetTurnPlayer().SelectCard(this, !selected);
    }



    public void SetSelected(bool newSelected)
    {
        if (isPreview)
        {
            return;
        }

        selected = newSelected;

        if (selected)
        {
            bg.color = bgSelectedColor;
        }

        else
        {
            bg.color = bgColor;
        }
    }



    public void SetInformation(CardInformation newInfo)
    {
        cardInfo = newInfo;

        name.text = newInfo.name;
        powerHealth.text = newInfo.power + "\n" + newInfo.health;

        string abilitiesText = "";

        foreach (CardAbility cardAbility in newInfo.abilities)
        {
            abilitiesText += "\n<color=#CC00CC>" + cardAbility.ability.ToString() + " <color=#CC0000>" + cardAbility.level;

            foreach (EDirection dir in cardAbility.directions)
            {
                abilitiesText += " <color=#009900>" + dir;
            }
        }

        abilities.text = abilitiesText;
    }
}
