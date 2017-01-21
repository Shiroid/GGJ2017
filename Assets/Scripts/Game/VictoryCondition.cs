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
        if (!winningPress[0]) return false;
        if (!winningPress[1])
        {
            if (!winningPress[2]) return false;
        }
        else
        {
            if (!winningPress[3]) return false;
        }
        if (!winningPress[4]) return false;
        if (winningPress[5]) return false;
        if (!winningPress[7]) return false;

        return true;
    }
}
