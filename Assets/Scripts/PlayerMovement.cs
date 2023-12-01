using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;
    Vector2 direction = new Vector2(0f, 0f);


    public Rigidbody2D playerRB;
    public float speed = 400;
    bool isFacingRight = true;
    public Animator animator;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Walk.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<Vector2>();
        };
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);
        animator.SetFloat("Speed", Mathf.Abs(direction.x + direction.y));

        if (isFacingRight && direction.x < 0 || !isFacingRight && direction.x >0)
            Flip();

    
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
}
