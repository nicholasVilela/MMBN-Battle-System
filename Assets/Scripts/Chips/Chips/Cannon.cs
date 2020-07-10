using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : Chip
{
    public Cannon() {
        chipName = "Cannon";
        chipEffects =  new List<ChipEffect>(){
            new ChipEffect {
                effectType = ChipEffectTypes.damage,
                animType = ChipAnimTypes.shoot,
                areaOfEffect = null,
                modifier = 20,
                offset = new Vector3(1f, 0, 0)
            }
        };
    }

    // public Cannon() : base(
    //     "Cannon",
    //     new List<Func<GameObject, ChipEffect>> {
    //                 ChipEffect.MakeChipEffectGenerator(
    //                     ChipEffectTypes.damage,
    //                     ChipAnimTypes.shoot,
    //                     null,
    //                     20
    //                 )
    //             },
    //     new Animator()
    // ) {}
}
