using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeD : MonoBehaviour
{

    private Character character; 
    
    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Character>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "player") {
            character.Death();
        }
    }
}
