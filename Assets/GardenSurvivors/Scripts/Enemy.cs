using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float damage = 1;

    public float Damage() => damage;

    private void OnDestroy() {
        EnemySpawner.RemoveZombie(this);
    }
}
