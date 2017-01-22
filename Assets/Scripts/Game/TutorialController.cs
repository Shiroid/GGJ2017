using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour {

    public Text[] buttonDisplays = new Text[Config.numPlayers];
    public float finishDelay;
    private bool success;
    private float delayLeft;

    public string nextScene;

    // Use this for initialization
    void Start () {
        GlobalVariables.canMove = true;
        success = false;
        delayLeft = finishDelay;

		for (int i = 0; i < Config.numPlayers; i++)
        {
            buttonDisplays[i].text = Config.playerKeys[i].ToString();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }

        if (!success)
        {
            bool allPressed = true;
            for (int i = 0; i < Config.numPlayers; i++)
            {
                allPressed &= GlobalVariables.buttonsPressed[i];
            }
            success = allPressed;
        }
        else
        {
            GlobalVariables.canMove = false;
            delayLeft -= Time.deltaTime;
            if(delayLeft < 0)  SceneManager.LoadScene(nextScene);
        }

	}
}
