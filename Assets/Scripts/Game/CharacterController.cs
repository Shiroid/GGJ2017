using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    protected int playerIndex = 0;


    public void SetPlayerIndex(int i)
    {
        playerIndex = i;
    }
}
