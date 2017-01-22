using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiVictoryCondition : VictoryCondition {

    public GameObject[] alternateConditions;

    override
    public bool isVictorious()
    {
        if (base.isVictorious()) return true;
        
        for (int i = 0; i < alternateConditions.Length; i++)
        {
            if (alternateConditions[i].GetComponent<VictoryCondition>().isVictorious()) return true;
        }
        return false;
    }
    public bool isVictorious2()
    {
        if (base.isVictorious()) return true;

        for (int i = 0; i < alternateConditions.Length; i++)
        {
            if (alternateConditions[i].GetComponent<VictoryCondition>().isVictorious()) return true;
        }
        return false;
    }
}
