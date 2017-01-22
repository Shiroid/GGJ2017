using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : CharacterController {

    public Sprite altSprite;
    private Sprite originalSprite;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>().sprite;
        Initialize();
    }

    override
    protected void setKeyDown(bool isDown)
    {
        base.setKeyDown(isDown);
        if (isKeyDown) GetComponent<SpriteRenderer>().sprite = altSprite;
        else GetComponent<SpriteRenderer>().sprite = originalSprite;
    }

}
