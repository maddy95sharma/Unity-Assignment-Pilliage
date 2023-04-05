using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AIConsideratinSO : ScriptableObject
{
    public string Name;
    private float score;
    public float Score{
        get{ return score; }
        set{ this.score = Mathf.Clamp01(value); }
    }

    public virtual void Awake()
    {
        score = 0;
    }

    public abstract float ConsiderationScore(NpcController npc);
}
