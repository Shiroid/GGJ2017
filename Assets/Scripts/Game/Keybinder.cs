using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keybinder : MonoBehaviour {

    private KeyCode[] keys = new KeyCode[Config.numPlayers];

    public Text keysDisplay;
    public Text notifier;

    private string notification = "Keys have been bound";

    public string returnScene = "Test Scene";
	
	// Update is called once per frame
	void Update ()
    {
        //Return if escape is pressed
        if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene(returnScene);
        if (notifier) notifier.text = "";

        //Check which keys are pressed
        int heldKeys = 0;
        foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(kcode) && kcode != KeyCode.Escape)
            {
                keys[heldKeys] = kcode;
                heldKeys++;
            }
            if (heldKeys == Config.numPlayers) break;
        }

        //Display which keys are pressed
        keysDisplay.text = "";
        for (int i = 0; i < heldKeys; i++)
        {
            keysDisplay.text += " " + keys[i];
        }

        //Bind keys if enough
        if(heldKeys == Config.numPlayers)
        {
            if (notifier) notifier.text = notification;
            Config.playerKeys = keys.Clone() as KeyCode[];
        }
    }
}
