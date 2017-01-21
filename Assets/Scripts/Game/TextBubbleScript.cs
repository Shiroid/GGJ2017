using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBubbleScript : MonoBehaviour {

    public Vector3 destination = new Vector3(0,0,0);
    public float speed = 0.05f;

    protected float roundedRotationSpeed;

	// Use this for initialization
	void Start () {

        float timeTraveled = (transform.position - destination).magnitude / speed;
        float rotationSpeed = speed * 86;
        float totalRotation = rotationSpeed * timeTraveled;
        float roundedRotation = totalRotation + (360 - totalRotation % 360);
        roundedRotationSpeed = rotationSpeed * roundedRotation / totalRotation;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, destination, speed);
        if (transform.position != destination)
        {
            transform.Rotate(Vector3.back * roundedRotationSpeed);
        }
    }
}
