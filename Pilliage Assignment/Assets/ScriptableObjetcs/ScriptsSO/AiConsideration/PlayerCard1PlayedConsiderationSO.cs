using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card1 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card1 Played Consideration")]

public class PlayerCard1PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.playerCard1Played ? 0 : 1;

    }
}
