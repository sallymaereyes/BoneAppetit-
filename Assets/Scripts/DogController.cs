﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour {

    public Camera cam;
    private float moveIncrement = .000000000000000001f;
    private float maxWidth;

	// Use this for initialization
	void Start () {
		

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