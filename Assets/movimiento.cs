using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Transform _transform;
    private SpriteRenderer _sprite;
    public int velocity;
    float X = 1;
    float Y = -1;

    void Awake()
    {
        _transform = GetComponent<Transform>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + X * velocity * Time.deltaTime, transform.position.y + Y * velocity * Time.deltaTime);
        Rotation();
    }

    void Rotation()
    {
        if (transform.position.x < -8f)
        {
            X = 1;
            _sprite.flipX = false;
        }
        else if (transform.position.x > 8f)
        {
            X = -1;
            _sprite.flipX = true;
        }
        else if (transform.position.y < -5f)
        {
            Y = 1;
            _sprite.flipY = true;
        }
        else if (transform.position.y > 5f)
        {
            Y = -1;
            _sprite.flipY = false;
        }
    }
}