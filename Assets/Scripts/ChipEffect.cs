using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipEffect : MonoBehaviour
{
    public string effectType {get; set;}
    public List<IntVector2> areaOfEffect {get; set;}

    public int modifier {get; set;}

    public ChipEffect(string effectType, List<IntVector2> areaOfEffect, int modifier) {
        this.effectType = effectType;
        this.areaOfEffect = areaOfEffect;
        this.modifier = modifier;
    }

    public void Execute(BattleObject user) {
        if (effectType == ChipEffectTypes.rayCast) {
            var hit = Physics2D.Raycast(user.transform.position, new Vector2(1, 0));

            if (hit.collider == null) return;

            var target = hit.collider.GetComponent<BattleObject>();
            
            if (target == null) return; 

            target.health -= modifier;
        }
    }
}
