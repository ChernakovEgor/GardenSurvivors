using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float leftRightDistance = 10;
    [SerializeField]
    private float upDownDistance = 8;

    [SerializeField]
    private Enemy enemy;
    [SerializeField]
    private float spawnTime = 1;
    [SerializeField]
    private Transform player;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    private void SpawnEnemy() {
        float x = Random.Range(-leftRightDistance, leftRightDistance);
        float y = Random.Range(-upDownDistance, upDownDistance);
        Enemy zombie = Instantiate(enemy);
        //_spawnedZombies.Add(zombie);
        Game.GetLevel.AddEnemy(zombie);
        zombie.transform.position = new Vector3(x, y, 0);
        SetupZombie(zombie.gameObject);
    }

    private void SetupZombie(GameObject zombie) {
        EnemyMovement movement = zombie.GetComponent<EnemyMovement>();
        movement.player = player;
    }
}
