using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhotographerController : MonoBehaviour {

    public float introTime = 2f;
    public float waitTime = 5f;
    public float photoFreeze = 3f;
    private float remainingTime;
    public string nextScene = "Test Scene";
    public Text countdownUI;
    public AudioSource clock;
    public AudioSource buzzer;
    private SpriteRenderer Overlay;
    public Object speechBaloon;
    private bool speech = false;
    public VictoryCondition victoryScript;

    public GameObject flash;

    private bool hasFlashed = false;
    private bool bubbleMade = false;
    private bool victorious = false;

    private float cameraScale = 1.0f;
    private float scaleSpeed = 0.04f;
    private float minScaleSpeed = 0.001f;

    public Camera camera;

    // Use this for initialization
    void Start () {
        remainingTime = waitTime + introTime;
        GlobalVariables.canMove = false;
        flash.SetActive(false);
        Overlay = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        remainingTime -= Time.deltaTime;
        if(countdownUI) countdownUI.text = Mathf.Round(remainingTime).ToString();
        if (remainingTime < waitTime && remainingTime > 0)
        {
            //Allow movement
            GlobalVariables.canMove = true;
            if (!clock.isPlaying)
            {
                clock.Play();
            }
        }
        if (remainingTime < 0 && !hasFlashed)
        {
            //Snap photo
            if (flash) flash.SetActive(true);
            GlobalVariables.canMove = false;
            countdownUI.text = "";
            clock.Stop();
            clock.time = 0.0f;
            speech = false;
            Overlay.color = new Color(1f, 1f, 1f, 0f);
            
        }

        if (remainingTime < -photoFreeze / 2)
        {
            if (!bubbleMade)
            {
                bubbleMade = true;

                switch (SceneManager.GetActiveScene().name)
                {
                    case "Scene Two":
                        victorious = victoryScript.isVictorious2();
                        break;
                    case "Scene Three":
                        victorious = victoryScript.isVictorious3();
                        break;
                    case "Scene Four":
                        victorious = victoryScript.isVictorious4();
                        break;
                    case "Scene Five":
                        victorious = victoryScript.isVictorious5();
                        break;
                }

                if (victorious)
                {
                    //Instantiate(speechBaloon);
                }
                else
                {
                    buzzer.Play();
                }
            }

            if(victorious && cameraScale < Config.victoryCameraScale)
            {
                float relScale = 1f + Mathf.Max(( 
                    Mathf.Min(Mathf.Abs(cameraScale - Config.victoryCameraScale), Mathf.Abs(cameraScale - 1f)) * scaleSpeed),
                     minScaleSpeed);
                cameraScale *= relScale;
                camera.orthographicSize *= relScale;
            }
        }

        if (remainingTime < -photoFreeze)
        {
            //Transition to next scene
            if (Config.savePhotos) Application.CaptureScreenshot(SceneManager.GetActiveScene().name + ".png");
            if(victorious) SceneManager.LoadScene(nextScene);
            else SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Overlay.color = new Color(1f, 1f, 1f, 1f);
        }
	}
}
