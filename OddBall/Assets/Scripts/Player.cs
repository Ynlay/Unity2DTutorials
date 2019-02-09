using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    
    private Rigidbody2D rb; 
    private int score; 

    public GameObject scorePoint; 
    public GameObject scoreText;

    public float jumpSpeed; // used

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }

    // Called when colliding with "isTrigger" collider objects
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "ScorePoint") {
            score += other.gameObject.GetComponent<ScorePoint>().GetScore();
            scoreText.GetComponent<Text>().text = " Score: " + score.ToString();
            Destroy(other.gameObject);

            int yRand = Random.Range(-4, 5);
            Instantiate(scorePoint, new Vector2(0, yRand), transform.rotation);
            
            Debug.Log("Score: " + score.ToString());
        }

        if (other.tag == "Death") {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
