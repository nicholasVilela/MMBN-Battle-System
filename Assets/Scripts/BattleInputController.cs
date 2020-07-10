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
        if (Input.GetKeyDown(KeyCode.X)) ChipController();
    }

    public void ChipController() {
        if (user.chips.Count() == 0 || user.chips == null) return;

        var chip = user.chips.FirstOrDefault();
        chip.UseEffect(user, gameObject);
        user.chips.Remove(chip);
        // chip.IfExists(chip => chip.UseEffect(user));
    }

    public void ShootController() {
        return;
    }
}
