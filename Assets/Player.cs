using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float health = 10;
    
    
    [SerializeField]
    private HealthUpdate update;

    [SerializeField]
    private GameObject gameOverScreen;
    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject enemy = collision.gameObject;
        Enemy zombie = enemy.GetComponent<Enemy>();
        GetHurt(zombie.Damage());
        update.UpdateHealth(health);
        
        Destroy(enemy);
    }
    
    private void GetHurt(float damage) {
        if (damage >= health)
            damage = health;
        
        health -= damage;

        if (health == 0) {
            gameOverScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
