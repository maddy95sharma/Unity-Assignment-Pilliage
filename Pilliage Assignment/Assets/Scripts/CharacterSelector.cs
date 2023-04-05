using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    private static CharacterSelector instance;
    public static CharacterSelector Instance{ get{return instance; } } 


    public CharacterSO[] characters;
    public GameObject CharcPanel;
    CharacterSO playerCharc;

    void Awake(){
        instance = this;
    }
    public void StartGame(int SeclectedCharc)
    {
        CharcPanel.SetActive(false);
        playerCharc = characters[SeclectedCharc];
        Card[] cards = GetComponentsInChildren<Card> ();
        for (int i =0; i<4; i++ )
        {
            cards[i].Initialize(playerCharc.cards[i]);
        }

    }    

    public CharacterSO GetCharc(){
        return playerCharc;
    }
}
