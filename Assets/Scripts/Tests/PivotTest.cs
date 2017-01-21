using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotTest : MonoBehaviour {

    public GameObject bar;
    public GameObject joint;

    // Use this for initialization
    void Start () {

        //Application.CaptureScreenshot("Screenshot.png");
    }
	
	// Update is called once per frame
	void Update () {
        ConfigTest.t = 40;
        if (Input.GetKey(KeyCode.Space))
            bar.GetComponent<Rigidbody2D>().AddForceAtPosition(
                Vector3.down*10, 
                joint.transform.position);
    }
}
