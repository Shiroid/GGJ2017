using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTest : MonoBehaviour {

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
        if (Input.GetKey(KeyCode.Alpha1)) spheres[0].SetActive(true);
        if (Input.GetKey(KeyCode.LeftShift)) spheres[1].SetActive(true);
        if (Input.GetKey(KeyCode.D)) spheres[2].SetActive(true);
        if (Input.GetKey(KeyCode.Alpha6)) spheres[3].SetActive(true);
        if (Input.GetKey(KeyCode.Space)) spheres[4].SetActive(true);
        if (Input.GetKey(KeyCode.K)) spheres[5].SetActive(true);
        if (Input.GetKey(KeyCode.UpArrow)) spheres[6].SetActive(true);
        if (Input.GetKey(KeyCode.Alpha0)) spheres[7].SetActive(true);
    }
}
