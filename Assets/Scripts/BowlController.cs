using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlController : MonoBehaviour
{
    private int score = 0;
    public Text scoreUI;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bone"))
        {
            score++;
            Debug.Log("Score " + score);
        }

        scoreUI.text = "Score: " + score;
    }
}