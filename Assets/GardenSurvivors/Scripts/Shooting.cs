using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private EnemySpawner spawner;
    private float _timeToShoot;

    private Enemy GetNearestEnemy() {
        if (EnemySpawner.SpawnedZombies.Count == 0)
            return null;

        Vector3 position = transform.position;
        Enemy nearestEnemy = EnemySpawner.SpawnedZombies[0];
        float minDistance = Vector3.Distance(position, nearestEnemy.transform.position);
        foreach (Enemy enemy in EnemySpawner.SpawnedZombies) {
            float distance = Vector3.Distance(position, enemy.transform.position);
            if (distance < minDistance) {
                nearestEnemy = enemy;
                minDistance = distance;
            }
        }

        return nearestEnemy;
    }

    private void Shoot(Enemy enemy) {
        GameObject spawnedProjectile = Instantiate(projectile);
        spawnedProjectile.transform.position = transform.position;
        Vector3 direction = enemy.transform.position - transform.position;
        spawnedProjectile.transform.rotation = Quaternion.FromToRotation(Vector3.up, 
                                                                        direction);
    }

    private void Update() {
        if (Time.time > _timeToShoot) {
            Enemy nearest = GetNearestEnemy();
            if (nearest != null) {
                Shoot(nearest);
                _timeToShoot += fireRate;
            }
        }
    }
}
