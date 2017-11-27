using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlController : MonoBehaviour
{
    private int score;
    public Text scoreUI;

    private int boneValue;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bone"))
        {
            score++;
            Debug.Log("Score " + score);
        }

        scoreUI.text = "Score: " + score;
    }

    

   /* void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine (spawn)
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        score += boneValue;
        UpdateScore();

    }

    void UpdateScore ()
    {
        scoreUI.text = "Score: " + score; 
    }
    */
}