using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public IntVector2 position {get; set;}
    public BattleObject obj {get; set;}
    public bool walkable {get; set;}
    public Vector3 worldPosition {get; set;}

    // public Panel(IntVector2 position, BattleObject obj, bool isRed, Vector2 worldPosition) {
    //     this.position = position;
    //     this.obj = obj;
    //     this.isRed = isRed;
    //     this.worldPosition = worldPosition;
    // }

    // public Panel() {}
}
