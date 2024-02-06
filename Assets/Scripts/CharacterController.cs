using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
    }

    void ProcessingMovement()
    {
        float inputMovement =
            Input.GetAxis("Horizontal");
        Rigidbody2D rigidBody =
            GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
    }
}
