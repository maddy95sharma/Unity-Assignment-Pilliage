using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public bool playerCard1Played, playerCard2Played, playerCard3Played, playerCard4Played ;
    public AIPredictor aiPredictor{get;set;}
    public AIActionSO[] ActionSO;

    void Awake()
    {
        aiPredictor = GetComponent<AIPredictor>();
    }


    public void onDiceClicked()
    {
        aiPredictor.DecideActionToDo(ActionSO);
    }

    void Update()
    {
        playerCard1Played = PlayerCardManager.Instance.IsCard1Played;
        playerCard2Played = PlayerCardManager.Instance.IsCard2Played;
        playerCard3Played = PlayerCardManager.Instance.IsCard3Played;
        playerCard4Played = PlayerCardManager.Instance.IsCard4Played;

    }

}
