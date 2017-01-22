using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    protected int playerIndex = -1;
    public int characterIndex;
    protected bool isKeyDown;

    public bool doRandomPose = false;
    protected bool invertPose;

    void Start()
    {
        Initialize();
    }

    protected void Initialize()
    {
        invertPose = Random.value > 0.5f;
        if (playerIndex < 0) playerIndex = characterIndex;
        setKeyDown(false);
    }

    public void SetPlayerIndex(int i)
    {
        playerIndex = i;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.canMove)
        {
            if (Input.GetKeyDown(Config.playerKeys[playerIndex]))
                this.setKeyDown(true);
            if (Input.GetKeyUp(Config.playerKeys[playerIndex]))
                this.setKeyDown(false);
                
        }
    }

    virtual protected void setKeyDown(bool isDown)
    {
        isKeyDown = isDown;
        if (doRandomPose && invertPose) isKeyDown = !isDown;
        GlobalVariables.buttonsPressed[characterIndex] = isKeyDown;
    }
}
