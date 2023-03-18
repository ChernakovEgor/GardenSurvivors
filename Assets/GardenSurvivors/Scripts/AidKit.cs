using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidKit : MonoBehaviour
{
    [SerializeField] private float _healAmount; 

    private void OnTriggerEnter2D (Collider2D collider) {
        Player player = collider.GetComponent<Player>();
        if (player != null) {
            player.Heal(_healAmount);
            Destroy(gameObject);
        }
    }
}
