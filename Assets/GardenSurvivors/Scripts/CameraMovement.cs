using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() {
        Vector3 position = player.position;
        float x = Mathf.Clamp(position.x, -Game.GetLevel.MapWidth, Game.GetLevel.MapWidth);
        float y = Mathf.Clamp(position.y, -Game.GetLevel.MapHeight, -Game.GetLevel.MapHeight);
        transform.position = new Vector3(x, y, -10);
    }
}
