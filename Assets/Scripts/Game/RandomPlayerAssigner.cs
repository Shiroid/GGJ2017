using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayerAssigner : MonoBehaviour {

    public GameObject[] controllables = new GameObject[8];

	// Use this for initialization
	void Start () {
        //Randomize which controlable 
        float[] randomNums = new float[controllables.Length];

		for(int i = 0; i < controllables.Length; i++)
        {
            randomNums[i] = Random.value;
        }

        for(int i = 0; i < controllables.Length; i++)
        {
            int maxIndex = 0;
            for(int j = 0; j < controllables.Length; j++)
            {
                if (randomNums[j] > randomNums[maxIndex])
                    maxIndex = j;
            }
            if(controllables[i])
                controllables[i].GetComponent<CharacterController>().SetPlayerIndex(maxIndex);
            randomNums[maxIndex] = -1f;
        }
	}
}
