using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        var movement = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, movement);

    }

}
