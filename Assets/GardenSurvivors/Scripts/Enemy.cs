using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float damage = 1;
    [SerializeField] private float health;
    [SerializeField] private int reward;
    private AudioSource _audio;
    public float Damage() => damage;

    private void Awake() {
        _audio = GetComponent<AudioSource>();
    }

    private void OnDestroy() {
        if (_audio != null) {
            _audio.enabled = true;
            _audio.Play();
        }
        Game.GetLevel.UpdateScore(reward);
        Game.GetLevel.RemoveZombie(this);
    }

    public void TakeDamage(float damage) {
        if (damage >= health)
            Destroy(gameObject);
        
        health = health - damage;
    }
}
