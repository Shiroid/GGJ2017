using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotographerController : MonoBehaviour {

    public float introTime = 2f;
    public float waitTime = 5f;
    public float photoFreeze = 3f;
    private float remainingTime;
    public string nextScene;

    public GameObject flash;

	// Use this for initialization
	void Start () {
        remainingTime = waitTime + introTime;
        GlobalVariables.canMove = false;
        flash.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        remainingTime -= Time.deltaTime;
        if (remainingTime < waitTime)
        {
            //Allow movement
            GlobalVariables.canMove = true;
        }
        if (remainingTime < 0)
        {
            //Snap photo
            if(flash) flash.SetActive(true);
            GlobalVariables.canMove = false;
        }
        if (remainingTime < -photoFreeze)
        {
            //Transition to next scene
            if (Config.savePhotos) Application.CaptureScreenshot(SceneManager.GetActiveScene().name + ".png");
            SceneManager.LoadScene(nextScene);
        }
	}
}
