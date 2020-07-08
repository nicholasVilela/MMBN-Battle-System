using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BattleObject
{
    public MovementController movement;
    public Vector3 offset = new Vector3(0, 0.15f, 0);
    public GameObject prefab;

    public PlayerController() : base (
        "Megaman",
        100,
        new IntVector2(1, 1)
    ) {}
}
