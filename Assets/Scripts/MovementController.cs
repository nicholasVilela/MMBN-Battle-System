using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public PlayerController obj;
    public Grid grid;

    private void Update() {
        InputController();
    }

    public void InputController() {
        if      (Input.GetKeyDown(KeyCode.RightArrow)) Move(new IntVector2( 1,  0));
        else if (Input.GetKeyDown(KeyCode.LeftArrow )) Move(new IntVector2(-1,  0));
        else if (Input.GetKeyDown(KeyCode.UpArrow   )) Move(new IntVector2( 0, -1));
        else if (Input.GetKeyDown(KeyCode.DownArrow )) Move(new IntVector2( 0,  1));
    }

    public void Move(IntVector2 dir) {
        var targetPos = obj.position;
        targetPos += dir;
        
        if (targetPos.x < 0 || targetPos.x > 5) return;
        if (targetPos.y < 0 || targetPos.y > 2) return;

        var targetPanel = grid.grid.Where(x => x.position == targetPos).FirstOrDefault();

        if (!targetPanel.walkable) return;

        UpdateObj(targetPos, targetPanel);
    }

    public void UpdateObj(IntVector2 targetPos, Panel targetPanel) {
        obj.position = targetPos;
        obj.transform.position = (targetPanel.worldPosition + obj.offset);
        grid.UpdateGrid(obj, targetPos);
    }
}