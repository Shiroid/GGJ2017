using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(GameObject.FindGameObjectsWithTag("Music").Length > 1)
        {
            GetComponent<AudioSource>().Stop();
            Debug.Log("this happened");
        }
        else
        {
            DontDestroyOnLoad(this);
            Debug.Log("that happened");
        }

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
