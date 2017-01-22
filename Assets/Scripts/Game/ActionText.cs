using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.localScale = new Vector3(100, 100, 100);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 1)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x-Time.deltaTime*100, this.transform.localScale.y - Time.deltaTime * 100, this.transform.localScale.z - Time.deltaTime * 100);
            if(this.transform.localScale.x < 1)
            {
                this.transform.localScale = new Vector3(1, 1, 1);
            }
        }
	}
}
