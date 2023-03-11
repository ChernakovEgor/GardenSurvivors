using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private SpriteRenderer _renderer;

    private void Awake() {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void SetFlip(bool isFlipped) {
        Vector3 position = transform.localPosition;
        if (isFlipped) {
            position.x = Mathf.Abs(position.x);
        } else {
            position.x = -Mathf.Abs(position.x);
        }

        transform.localPosition = position;

        _renderer.flipX = isFlipped;
    }
}
