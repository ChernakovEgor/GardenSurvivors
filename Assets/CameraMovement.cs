using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float leftRightDistance = 10;
    public float upDownDistance = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Restrict();
    }

    void Move() {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }

    void Restrict() {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -leftRightDistance, leftRightDistance);
        position.y = Mathf.Clamp(position.y, -upDownDistance, upDownDistance);
        transform.position = position;
    }
}
