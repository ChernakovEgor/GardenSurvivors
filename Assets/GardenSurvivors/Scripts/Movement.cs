using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public float leftRightDistance = 10;
    public float upDownDistance = 10;

    public void Move() {
        Vector2 movement = MovementFromInput();
        transform.Translate(movement);
        RestrictPosition();
    }

    public Vector2 MovementFromInput() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        return movement.normalized * Time.deltaTime * speed;
    }

    void RestrictPosition() {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -leftRightDistance, leftRightDistance);
        position.y = Mathf.Clamp(position.y, -upDownDistance, upDownDistance);
        transform.position = position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
