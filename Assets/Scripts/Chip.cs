using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    public string chipName {get; set;}
    public List<ChipEffect> chipEffects {get; set;}

    public Chip(string chipName, List<ChipEffect> chipEffects) {
        this.chipName = chipName;
        this.chipEffects = chipEffects;
    }

    public void UseEffect(BattleObject user) {
        chipEffects.ForEach(eff => {
            eff.Execute(user);
        });
    }
}
