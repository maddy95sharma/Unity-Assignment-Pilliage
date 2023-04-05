using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card3 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card3 Played Consideration")]

public class PlayerCard3PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.playerCard3Played ?  0 : 1;
    }
}
