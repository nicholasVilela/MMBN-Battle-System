using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleInputController : MonoBehaviour
{
    public BattleObject user;

    private void Update() {
        InputController();
    }

    public void InputController() {
        if (Input.GetKeyDown(KeyCode.Z)) ShootController();
        if (Input.GetKeyDown(KeyCode.X) && user.chips.Count() > 0) ChipController();
    }

    public void ChipController() {
        var chip = user.chips.FirstOrDefault();
        Debug.Log(chip.chipName);
        chip.UseEffect(user);
    }

    public void ShootController() {
        return;
    }
}
