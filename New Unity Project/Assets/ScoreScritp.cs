using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScritp : MonoBehaviour
{
   public static int Score = 0;
    public Text Completed;  

    // Start is called before the first frame update
    void Start()
    {
        Completed = GetComponent<Text>();
        
    }

    // Update is called once per frame
    public void Update()
    {
        Completed.text = ""+Score;
        
    }
}
