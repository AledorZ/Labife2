using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodScript : MonoBehaviour
{
    public bool isGood = true;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGood == true)
        {
            ScoreScritp.Score += 1;
        }
        
    }
}
