using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100;
    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject enemy = collision.gameObject;
        Destroy(enemy);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
