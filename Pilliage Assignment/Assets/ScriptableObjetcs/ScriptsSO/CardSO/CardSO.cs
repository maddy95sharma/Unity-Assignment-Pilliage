using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Release,
    Revive,
    PushBack,
    DefendPlayer,
    DefendBase,
    RollTwice,
    DoubleTheRoll
}
public abstract class CardSO : ScriptableObject
{
    public new string name;
    public CardType type;

}