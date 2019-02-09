using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public Rigidbody2D rb;

    public Transform groundCheck; 
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public float speed = 5f;

    private bool onGround;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(KeyCode.Space) && onGround) {
            rb.velocity = new Vector2 (rb.velocity.x, speed);
        }

    }
}
