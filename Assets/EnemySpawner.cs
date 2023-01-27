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
    private GameObject enemy;
    [SerializeField]
    private float spawnTime = 1;
    [SerializeField]
    private Transform player;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy() {
        float x = Random.Range(-leftRightDistance, leftRightDistance);
        float y = Random.Range(-upDownDistance, upDownDistance);
        GameObject zombie = Instantiate(enemy);
        zombie.transform.position = new Vector3(x, y, 0);
        SetupZombie(zombie);
    }

    private void SetupZombie(GameObject zombie) {
        EnemyMovement movement = zombie.GetComponent<EnemyMovement>();
        movement.player = player;
    }
}
