using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public float leftRightDistance = 10;
    public float upDownDistance = 10;

    private Animator _animator;
    private SpriteRenderer _renderer;

    public void Move() {
        Vector2 movement = MovementFromInput();
        transform.Translate(movement);
        RestrictPosition();
    }

    public Vector2 MovementFromInput() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);

        if (x == 0 && y == 0)
            _animator.SetBool("isRunning", false);
        else 
            _animator.SetBool("isRunning", true);

        if (x < 0)
            _renderer.flipX = true;
        if (x > 0) 
            _renderer.flipX = false;

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
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
