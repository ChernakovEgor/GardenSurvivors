using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float health = 10;
    [SerializeField] private GameObject blood;
    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject enemy = collision.gameObject;
        Enemy zombie = enemy.GetComponent<Enemy>();
        
        if (zombie != null) {
            GetHurt(zombie.Damage());
            //uiManager.UpdateHealth(health);
            Game.GetLevel.OnPlayerTakeDamage(health);
            Destroy(enemy);
        }
    }
    
    private void GetHurt(float damage) {
        if (damage >= health)
            damage = health;
        
        health -= damage;

        if (health == 0) {
            //uiManager.ShowLoseScreen();
            Game.GetLevel.OnPlayerDead();
            gameObject.SetActive(false);
        }

        Instantiate(blood, transform.position, Quaternion.identity);
    }
}
