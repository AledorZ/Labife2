using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScore : MonoBehaviour
{
    public float TimerToWin = 0.0f;
    [SerializeField] bool Agarisin = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Agarisin == true)
        {
            Timer();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickupable"))
        {
            Agarisin = true;
            Debug.Log("AgarIsin");
           // ScoreScritp.ScoreCOP += 1;
           // ScoreScritp.ScoreAML -= 1;
            //ScoreScritp.ScoreCOT += 1;
        }
    }
    public void Timer()
    {
        TimerToWin += Time.deltaTime;
        if(TimerToWin >= 8.0f)
        {
            ScoreScritp.ScoreCOT = +1;
        }
        
    }
}

