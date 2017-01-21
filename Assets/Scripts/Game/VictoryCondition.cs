using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour {
    
    public bool[] winningPress = new bool[Config.numPlayers];
	
    public virtual bool isVictorious()
    {
        for (int i = 0; i < Config.numPlayers; i++)
        {
            if (winningPress[i] != GlobalVariables.buttonsPressed[i]) return false;
        }
        return true;
    }
}
