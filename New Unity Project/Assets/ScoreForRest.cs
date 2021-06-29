using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreForRest : MonoBehaviour
{
    public bool Agarisin = false;
    public bool Showup = true;
    
    public GoodScript Reallygood;
    public Isbad Bad;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Isreallybad = GameObject.FindGameObjectWithTag("Bad");
        Isbad isbad = Isreallybad.GetComponent<Isbad>();
        Bad = isbad;

        GameObject Good = GameObject.FindGameObjectWithTag("Pickupable");
        GoodScript good = Good.GetComponent<GoodScript>();
        Reallygood = good;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickupable"))
        {


            Reallygood.isGood = true;
            Agarisin = true;
            Debug.Log("AgarIsin");
            Reallygood.destorthis();


            //ScoreScritp.ScoreCOP += 1;
            ScoreScritp.ScoreAML -= 1;

        }
        if (other.CompareTag("Bad"))
        {
            Bad.bad = true;


            Agarisin = true;
            Debug.Log("AgarIsin");



            ScoreScritp.ScoreAML -= 1;
            ScoreScritp.ScoreCOT += 1;
        }
    }
}
