using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float damage = 1;
    [SerializeField] private float health;
    [SerializeField] private int reward;

    public float Damage() => damage;

    private void OnDestroy() {
        //EnemySpawner.RemoveZombie(this);
        Game.GetLevel.UpdateScore(reward);
        Game.GetLevel.RemoveZombie(this);
    }

    public void TakeDamage(float damage) {
        if (damage >= health)
            Destroy(gameObject);
        
        health = health - damage;
    }
}
