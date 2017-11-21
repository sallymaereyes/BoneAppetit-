using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Camera cam;
    public GameObject bone;
    public float timeLeft = 30.0f;
    public Text timerText;

    private float maxWidth;

    void Start ()
    {
        if(cam == null)
        {
            cam = Camera.main;
        }

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float boneWidth = bone.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - boneWidth;
        StartCoroutine(Spawn());
    }

    
    void Update ()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <0)
        {
            timeLeft = 0;
        }
        Debug.Log("Time Left = " + timeLeft);

        timerText.text = "Time Left: " + Mathf.RoundToInt(timeLeft);
    }
    

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.0f);
        while (timeLeft > -10)
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
    }

    

}
