using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card2 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card2 Playable")]

public class PlayerCard2PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 2 is not used and can be used");
    }

}
