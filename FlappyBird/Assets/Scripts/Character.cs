using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;

    public GameObject pipe_up;
    public GameObject pipe_down;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BuildLevel();    
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }

        if (transform.position.y > 18 || transform.position.y < -19) {
            Death();
        }

    }

    public void BuildLevel() 
    {
        Instantiate(pipe_down, new Vector3(14,5), transform.rotation);
        Instantiate(pipe_up, new Vector3(14, -4), transform.rotation);

        Instantiate(pipe_down, new Vector3(26, 4), transform.rotation);
        Instantiate(pipe_up, new Vector3(26, -3), transform.rotation);

        Instantiate(pipe_down, new Vector3(38, 5), transform.rotation);
        Instantiate(pipe_up, new Vector3(38, -7), transform.rotation);

        Instantiate(pipe_down, new Vector3(50, 3), transform.rotation);
        Instantiate(pipe_up, new Vector3(50, -5), transform.rotation);

        Instantiate(pipe_down, new Vector3(61, 4), transform.rotation);
        Instantiate(pipe_up, new Vector3(61, -4), transform.rotation);
    }

    public void Death() {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
    }
}
