using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Text scoreText;
    public int boneValue;

    private int score;

	// Use this for initialization
	void Start () {

        score = 0;
        UpdateScore();
	}
	
    void OnTriggerEnter2D ()
    {
        score += boneValue;
        UpdateScore();
    }

	void UpdateScore () {
        scoreText.text = "Score: " + score;
    }
    
}
