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
    public virtual bool isVictorious2()
    {
        if (!GlobalVariables.buttonsPressed[0]) return false;
        if (!GlobalVariables.buttonsPressed[1]) 
        {
            if (!GlobalVariables.buttonsPressed[2]) return false; 
        }
        else
        {
            if (!GlobalVariables.buttonsPressed[3])  return false; 
        }
        if (!GlobalVariables.buttonsPressed[4]) return false; 
        if (GlobalVariables.buttonsPressed[5]) return false; 
        if (!GlobalVariables.buttonsPressed[7])  return false;

        return true;
    }
}
