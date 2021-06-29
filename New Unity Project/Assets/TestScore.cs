using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TestScore : MonoBehaviour
{
    public float TimerToWin = 0.0f;
    public bool Agarisin = false;
    public Tutorial Score;
    public Text Header;
    public Text description;
    public Image background;
    public bool Showup = true;
    public GameObject Uibeingshown;
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


        Header.text = Score.name;
        description.text = Score.Discription;
        background.sprite = Score.background;
        
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
    private void OnTriggerExit(Collider other)
    {
        Agarisin = false;
    }


    //public void Timer()
    //{
    //    TimerToWin += Time.deltaTime;
    //    if(TimerToWin >= 3.0f)

    //    {
    //        Agarisin = false;
    //        TimerToWin = 0.0f;
    //        Reallygood.destorthis();
    //        Showup = true;
    //        //Bad.Destorthis();
           
    //        //ScoreScritp.ScoreCOT = +1;
    //    }
        
    //}
    public void Okdokie()
    {
        Uibeingshown.SetActive(false);
        Showup = false;
    }

   
}

