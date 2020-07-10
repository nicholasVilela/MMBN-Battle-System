using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    // public string chipName {get; set;}
    // // public List<ChipEffect> chipEffects {get; set;}
    // public List<Func<GameObject, ChipEffect>> chipEffects {get; set;}
    // public Animator anim {get; set;}

    public string chipName;
    // public List<Func<GameObject, ChipEffect>> chipEffects;
    public List<ChipEffect> chipEffects;
    public GameObject obj;


    // public Chip(string chipName, List<ChipEffect> chipEffects) {
    // public Chip(string chipName, List<Func<GameObject, ChipEffect>> chipEffects, Animator anim) {
    //     this.chipName = chipName;
    //     this.chipEffects = chipEffects;
    //     this.anim = anim;
    // }

    public void UseEffect(BattleObject user, GameObject obj) {
        // chipEffects.ForEach(eff => {
        //     eff(obj).Execute(user, obj);
        // });

        chipEffects.ForEach(eff => {
            eff.Execute(user);
        });
    }
}
