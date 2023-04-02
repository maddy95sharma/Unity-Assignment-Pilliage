using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Power Card", menuName = "ScriptableObject/Charcter")]
public class CharacterSO : ScriptableObject
{
    public new string name;
    public CardSO[] cards;

}
