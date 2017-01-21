using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : CharacterController {

    public Sprite altSprite;
    private Sprite originalSprite;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>().sprite;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GlobalVariables.canMove)
        {
            if (Input.GetKeyDown(Config.playerKeys[playerIndex]))
                GetComponent<SpriteRenderer>().sprite = altSprite;
            if (Input.GetKeyUp(Config.playerKeys[playerIndex]))
                GetComponent<SpriteRenderer>().sprite = originalSprite;
        }
    }
}
