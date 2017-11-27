using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour {

    public Camera cam;
    private float moveIncrement = .0000001f;
    private float maxWidth;

    public Renderer rend;

	// Use this for initialization
	void Start () {
		
        if(cam == null)
        {
            cam = Camera.main;
        }
        rend = GetComponent<Renderer>();

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        // float dogWidth = renderer.bounds.extents.x;
        float dogWidth = rend.bounds.extents.x;
        maxWidth = targetWidth.x - dogWidth;
	}
	
	// Update is called once per frame
	void Update () {

         if (Input.GetKey(KeyCode.RightArrow))
         {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
         }

    }

}
