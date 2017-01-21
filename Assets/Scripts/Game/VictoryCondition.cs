using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour {
    
    public bool[] winningPress = new bool[Config.numPlayers];

    public GameObject[] errors;
	
    public virtual bool isVictorious()
    {
        for (int i = 0; i < Config.numPlayers; i++)
        {
            if (winningPress[i] != GlobalVariables.buttonsPressed[i]) return false;
        }
        return true;
    }

    private bool markError(int i)
    {
        if (errors[i]) errors[i].SetActive(true);
        return false;
    }

    public virtual bool isVictorious2()
    {
        bool result = true;
        if (!GlobalVariables.buttonsPressed[0]) result = markError(0);
        if (!GlobalVariables.buttonsPressed[1])
        {
            if (!GlobalVariables.buttonsPressed[2]) result = markError(1);
        }
        else
        {
            if (!GlobalVariables.buttonsPressed[3]) result = markError(2);
        }
        if (!GlobalVariables.buttonsPressed[4]) result = markError(3);
        if (GlobalVariables.buttonsPressed[5]) result = markError(4);
        if (!GlobalVariables.buttonsPressed[7]) result = markError(5);

        return result;
    }

    public virtual bool isVictorious3()
    {
        bool result = true;
        if (GlobalVariables.buttonsPressed[1]) result = markError(0);
        if (!GlobalVariables.buttonsPressed[2]) result = markError(1);
        if (GlobalVariables.buttonsPressed[3])
        {
            if (!GlobalVariables.buttonsPressed[7]) result = markError(2);
        }
        if (!GlobalVariables.buttonsPressed[4]) result = markError(3);
        if (GlobalVariables.buttonsPressed[5]) result = markError(4);
        if (!GlobalVariables.buttonsPressed[6]) result = markError(5);

        return result;
    }
}
