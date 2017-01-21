using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapTest : MonoBehaviour {

    public Sprite alt;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {
            
            Sprite temp = GetComponent<SpriteRenderer>().sprite;
            GetComponent<SpriteRenderer>().sprite = alt;
            alt = temp;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
        }
    }
}
