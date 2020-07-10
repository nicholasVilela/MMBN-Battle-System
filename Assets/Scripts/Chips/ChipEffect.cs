using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipEffect : MonoBehaviour
{
    public string effectType;
    public string animType;
    public List<IntVector2> areaOfEffect;
    public int modifier;
    public GameObject obj;
    public Vector3 offset;

    public void Execute(BattleObject user) {
        EffectController(animType, user); 
    }

    public void Shoot(BattleObject user) {
        var hit = Physics2D.Raycast(user.transform.position, new Vector2(1, 0));

        if (hit.collider == null) return;
        var target = hit.collider.GetComponent<BattleObject>();
        
        if (target == null) return; 
        ApplyModifier(target);
    }

    public IEnumerator ShootCoroutine(BattleObject user) {
        yield return new WaitForSeconds(0.3f);
        Shoot(user);
        yield return new WaitForSeconds(0.10f);
        user.canMove = true;
    }

    public IEnumerator EffectAnimationCoroutine(float time, string animType, BattleObject user) {
        SetAnimationPosition(user);

        var anim = obj.GetComponent<Animator>();

        if (animType == ChipAnimTypes.shoot) yield return new WaitForSeconds(0.2f);

        anim.Play(animType);
        yield return new WaitForSeconds(20f);

        Destroy(obj);
    }

    public void SetAnimationPosition(BattleObject user) {
        obj.transform.position = (user.transform.position + offset);
    }

    public void EffectController(string anim, BattleObject user) {
        var playerAnim = user.GetComponent<Animator>();
        user.canMove = false;

        playerAnim.Play(anim);

        StartCoroutine(EffectAnimationCoroutine(1f, anim, user));
        if (animType == ChipAnimTypes.shoot) StartCoroutine(ShootCoroutine(user));
    }

    public void ApplyModifier(BattleObject target) {
        if (effectType == ChipEffectTypes.damage) target.health -= modifier;
    }

}
