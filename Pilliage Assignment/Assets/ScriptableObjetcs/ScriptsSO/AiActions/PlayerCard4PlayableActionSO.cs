using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card4 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card4 Playable")]

public class PlayerCard4PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 4 is not used and can be used");
    }

}
