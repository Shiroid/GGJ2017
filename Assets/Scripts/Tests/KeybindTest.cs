using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeybindTest : MonoBehaviour {

    private KeyCode[] keys = new KeyCode[8];
    public Text[] displays = new Text[8];

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int index = 0;
        foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(kcode))
            {
                keys[index] = kcode;
                index++;
            }
        }
        for(int i = 0; i < 8; i++)
        {
            if (i < index) displays[i].text = "Pressed: " + keys[i];
            else displays[i].text = "No key";
        }
    }
}
