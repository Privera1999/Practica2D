using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int maxJumps = 2;
    private int jumpsRemaining;
    Rigidbody2D rigidBody;
    private float inputMovement;
    public bool isLookingRight = true;
    public BoxCollider2D boxCollider;
    public bool isOnFloor = false;

    private AudioSource audioSource;
        public AudioClip jumpClip;

    public LayerMask surfaceLayer;

    public bool isRunning;
    private Animator animator;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        jumpsRemaining = maxJumps;
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
        isOnFloor = CheckingFloor();
        ProcessingJump();
    }

    bool CheckingFloor()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(
                                        boxCollider.bounds.center,
                                        new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y),
                                        0f,
                                        Vector2.down,
                                        0.1f,
                                        surfaceLayer
                                        );
        animator.SetBool("isOnFloor", isOnFloor);

        // Restablecer el número de saltos restantes cuando toca el suelo
        if (raycastHit.collider != null)
        {
            jumpsRemaining = maxJumps;
        }

        return raycastHit.collider != null;
    }

    void ProcessingJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0f);
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpsRemaining--;

            audioSource.PlayOneShot(jumpClip);
        }
    }

    void ProcessingMovement()
    {
        inputMovement = Input.GetAxis("Horizontal");
        isRunning = inputMovement != 0 ? true : false;
        animator.SetBool("isRunning", isRunning);
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
        CharacterOrientation(inputMovement);
    }

    void CharacterOrientation(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
