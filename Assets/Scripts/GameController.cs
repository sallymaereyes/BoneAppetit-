using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Camera cam;
    public GameObject bone;
    public float timeLeft = 20;
    public Text timerText;

    public GameObject gameOverText;
    public GameObject restartButton;

    public GameObject startButton;
    public GameObject splashScreen;

    private float maxWidth;
    private bool playing;

    void Start ()
    {
        if(cam == null)
        {
            cam = Camera.main;
        }

        playing = false;

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float boneWidth = bone.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - boneWidth;
        UpdateText();
    }

    
    void FixedUpdate ()
    {
        if (playing)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.RoundToInt(timeLeft);
            if (timeLeft < 0)
            {
                timeLeft = 0;
            }
            Debug.Log("Time Left = " + timeLeft);

            UpdateText();
        }
    }

    public void StartGame()
    {
        splashScreen.SetActive(false);
        startButton.SetActive(false);
        StartCoroutine(Spawn());
    }

    void UpdateText() 
    {
        timerText.text = "Time Left: " + Mathf.RoundToInt(timeLeft);
    }
    

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.0f);
        while (timeLeft > 0)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-maxWidth, maxWidth),
                transform.position.y,
                0.0f
                );

            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(bone, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }

        yield return new WaitForSeconds(1.0f);

        gameOverText.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        restartButton.SetActive(true);
    }

    

}
