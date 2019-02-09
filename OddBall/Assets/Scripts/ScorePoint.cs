using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    private SpriteRenderer sr; 
    private int score;

    public Color colorBlue;
    public Color colorOrange;
    public Color colorGreen;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomColor() {
        int index = Random.Range(0, 3);

        switch(index) {
            case 0: 
                sr.color = colorBlue;
                break;
            case 1: 
                sr.color = colorOrange;
                break;
            case 2: 
                sr.color = colorGreen;
                break;
        }

        if (sr.color == colorGreen) {
            score = 5;
        } else if (sr.color == colorOrange) {
            score = 10; 
        } else score = 15;
    }

    public int GetScore() {
        return score;
    }
}
