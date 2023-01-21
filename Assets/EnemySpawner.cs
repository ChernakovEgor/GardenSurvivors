using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float spawnDelay = 1;
    public float leftRightDistance;
    public float upDownDistance;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        GameObject enemy = Instantiate(prefab);
        SetupEnemy(enemy);
    }

    private Vector3 GetRandomPosition() {
        float x = Random.Range(-leftRightDistance, leftRightDistance);
        float y = Random.Range(-upDownDistance, upDownDistance);
        return new Vector3(x, y, 0);
    }

    private void SetupEnemy(GameObject enemy) {
        Vector3 position = GetRandomPosition();
        enemy.transform.position = position;
        EnemyMovement movement = enemy.GetComponent<EnemyMovement>();
        movement.player = player;
    }
}
