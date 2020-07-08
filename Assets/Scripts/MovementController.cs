using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public BattleObject obj;
    public Grid grid;

    private void Update() {
        InputController();
    }

    public void InputController() {
        if      (Input.GetKeyDown(KeyCode.RightArrow)) Move(new IntVector2( 1,  0));
        else if (Input.GetKeyDown(KeyCode.LeftArrow )) Move(new IntVector2(-1,  0));
        else if (Input.GetKeyDown(KeyCode.UpArrow   )) Move(new IntVector2( 0,  1));
        else if (Input.GetKeyDown(KeyCode.DownArrow )) Move(new IntVector2( 0, -1));
    }

    public void Move(IntVector2 dir) {
        return;
    }
}
