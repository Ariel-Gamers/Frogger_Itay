using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 0.7f;
    private Rigidbody2D body;

    void OnCollisionEnter2D(Collision2D data)
    {
        Debug.Log("Collision detected");
    }
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        body.velocity = new Vector2(horizontal * speed, vertical*speed);
    }
}
