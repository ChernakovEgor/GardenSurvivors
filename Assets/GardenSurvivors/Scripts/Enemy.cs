using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float damage = 1;
    [SerializeField] private float health;

    public float Damage() => damage;

    private void OnDestroy() {
        EnemySpawner.RemoveZombie(this);
    }

    public void TakeDamage(float damage) {
        if (damage >= health)
            Destroy(gameObject);
        
        health = health - damage;
    }
}
