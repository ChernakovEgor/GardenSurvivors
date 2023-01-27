using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private float leftRightDistance = 4;
    [SerializeField]
    private float upDownDistance = 4;
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
        float x = Mathf.Clamp(position.x, -leftRightDistance, leftRightDistance);
        float y = Mathf.Clamp(position.y, -upDownDistance, upDownDistance);
        transform.position = new Vector3(x, y, -10);
    }
}
