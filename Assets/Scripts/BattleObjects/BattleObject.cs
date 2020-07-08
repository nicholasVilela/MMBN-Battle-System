using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BattleObject : MonoBehaviour
{
    public string battleName {get; set;}
    public int health { get; set; }
    public IntVector2 position {get; set;}
}
