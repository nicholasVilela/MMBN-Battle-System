using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public IntVector2 position {get; set;}
    public BattleObject obj {get; set;}
    public bool isRed {get; set;}

    public Panel(IntVector2 position, BattleObject obj, bool isRed) {
        this.position = position;
        this.obj = obj;
        this.isRed = isRed;
    }
}
