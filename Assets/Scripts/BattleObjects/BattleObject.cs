using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class BattleObject : MonoBehaviour
{
    public string battleName {get; set;}
    public int health { get; set; }
    public IntVector2 position {get; set;}
    public List<Chip> chips {get; set;}

    public BattleObject(string battleName, int health, IntVector2 position, List<Chip> chips) {
        this.battleName = battleName;
        this.health = health;
        this.position = position;
        this.chips = chips;
    }

    private void Update() {
        HealthController();
    }

    public void HealthController() {
        if (this.health > 0) return;

        this.Delete();
    }

    public void Delete() {
        Destroy(gameObject);
    }
}