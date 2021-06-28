using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isbad : MonoBehaviour
{
    public GameObject Me;
    public bool bad = false;
    TestScore Testing;

    // Update is called once per frame
    void Update()
    {
        GameObject Test = GameObject.FindGameObjectWithTag("Trigger");
        TestScore Ts = Test.GetComponent<TestScore>();
        Testing = Ts;
    }
    public void Destorthis()
    {
        ScoreScritp.ScoreCOT = +1;
        this.gameObject.SetActive(false);
        Testing.Agarisin = false;
        bad = false;
    }

}
