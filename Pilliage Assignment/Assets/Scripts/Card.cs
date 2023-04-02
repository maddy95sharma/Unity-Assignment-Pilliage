using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Card : MonoBehaviour
{
    // public CardSO card;
    private CardType type;
    public Text nameText;

    public void Initialize(CardSO card)
    {
        type = card.type;
        nameText.text = card.name; 
    } 

    public CardType GetCardType()
    {
        return type;
    }

}
