using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRectangle : MonoBehaviour
{

    public float speed;
    public bool goingRight; 

    private GameObject DM;

    // Start is called before the first frame update
    void Start() {
        DM = GameObject.Find("DeathManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (goingRight) {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0); 
        } else transform.position -= new Vector3(speed * Time.deltaTime, 0, 0); 
    
        if (transform.position.x > 15 || transform.position.x < -15) {
            Destroy(gameObject);
            DM.GetComponent<DeathManager>().setSpawn(true);
        }

        
    }
}
