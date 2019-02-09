using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject DeathRectangleLeft;
    public GameObject DeathRectangleRight;

    private bool spawn; 
    // Start is called before the first frame update
    void Start() {
        setSpawn(true);
        CreateDeath();
    }

    void Update() {
        if (spawn) CreateDeath();
    }
    
    public void CreateDeath() {
        
        if (spawn) {
            int left = Random.Range(1, 3);
            int right = Random.Range(1, 3);

            for (int i=0; i<left; i++) {
                int yRand = Random.Range(-4,5);
                Instantiate (DeathRectangleLeft, new Vector2(15, yRand), transform.rotation);
            }

            for (int i=0; i<right; i++) {
                int yRand = Random.Range(-4,5);
                Instantiate (DeathRectangleRight, new Vector2(-15, yRand), transform.rotation);
            } 

            setSpawn(false);
        }
       
    }

    public void setSpawn(bool spawn) {
        this.spawn = spawn;
    }   
}
