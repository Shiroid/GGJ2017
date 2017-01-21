using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlasher : MonoBehaviour {

    private float opacity;
    public float flashTime = 0.3f;
    public float baseOpacity = 1f;
    public AudioSource cameraClick;

    // Use this for initialization
    void OnEnable () {
        opacity = baseOpacity;
        cameraClick.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, opacity);
        opacity -= Time.deltaTime * baseOpacity / flashTime;
    }
}
