using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashTest : MonoBehaviour {

    private float opacity;

	// Use this for initialization
	void OnEnable () {
        opacity = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacity);
        opacity -= Time.deltaTime*3;
    }
}
