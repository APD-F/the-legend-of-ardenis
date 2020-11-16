using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfPlayer : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rigBody;
    public Animator animator;
    Vector2 movement;

    // Update is called once per frame. This function handles input
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // executed on fixed timer, which is more reliable when dealing with physics. This function handles movement
    void FixedUpdate()
    {
        rigBody.MovePosition(rigBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }
}