using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private float lifetime;
    [SerializeField] private int penetration;
    private float _timeToDestroy;

    private void Start() {
        _timeToDestroy = Time.time + lifetime;
    }

    private void FixedUpdate() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (Time.time > _timeToDestroy)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        Enemy shotEnemy = collider.GetComponent<Enemy>();
        if (shotEnemy != null) {
            shotEnemy.TakeDamage(damage);

            penetration--;
            if (penetration < 0)
                Destroy(gameObject);
        }
    }
}
