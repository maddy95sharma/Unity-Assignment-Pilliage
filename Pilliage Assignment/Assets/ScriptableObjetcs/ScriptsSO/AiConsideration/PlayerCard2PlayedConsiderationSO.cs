using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card2 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card2 Played Consideration")]

public class PlayerCard2PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.playerCard2Played ? 0 : 1;
    }
}
