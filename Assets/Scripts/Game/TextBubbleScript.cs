﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBubbleScript : MonoBehaviour {

    public Vector3 destination = new Vector3(0,0,0);
    public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed);
        if (transform.position != destination)
        {
            transform.Rotate(Vector3.back * speed * 86);
        }
    }
}
