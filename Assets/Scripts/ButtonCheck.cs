using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour {

    public GameObject[] spheres;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < spheres.Length; i++)
        {
            spheres[i].SetActive(false);
        }
        if (Input.GetKey(KeyCode.A)) spheres[0].SetActive(true);
        if (Input.GetKey(KeyCode.J)) spheres[1].SetActive(true);
        if (Input.GetKey(KeyCode.K)) spheres[2].SetActive(true);
        if (Input.GetKey(KeyCode.L)) spheres[3].SetActive(true);
        if (Input.GetKey(KeyCode.Semicolon)) spheres[4].SetActive(true);
        if (Input.GetKey(KeyCode.F)) spheres[5].SetActive(true);
        if (Input.GetKey(KeyCode.D)) spheres[6].SetActive(true);
        if (Input.GetKey(KeyCode.S)) spheres[7].SetActive(true);
    }
}
