using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour {

    public Sprite altSprite;
    private Sprite currentSprite;
    public string sceneLoadName;


	// Use this for initialization
	void Start () {
        currentSprite = GetComponent<SpriteRenderer>().sprite;
    }


    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = altSprite;

    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = currentSprite;
    }
    void OnMouseDown()
    {
        Application.LoadLevel(sceneLoadName);
    }
    //Update is called once per frame
    void Update () {
        
		
	}
}
