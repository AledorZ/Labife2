using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TestScore : MonoBehaviour
{
    public float TimerToWin = 0.0f;
    public bool Agarisin = false;
    
    public Text Header;
    public Text description;
    public Image background;
    public bool Showup = true;
    public GameObject Uibeingshown;
    public GoodScript Reallygood;
    public Isbad Bad;
    public GameObject FPS;
    
    


    // Start is called before the first frame update
    void Start()


    {
        FPS = GameObject.Find("FPSController"); FPS.GetComponentInChildren<Camera>();
        GameObject Good = GameObject.FindGameObjectWithTag("Pickupable");
        GoodScript good = Good.GetComponent<GoodScript>();
        Reallygood = good;


        GameObject Isreallybad = GameObject.FindGameObjectWithTag("Bad");
        Isbad isbad = Isreallybad.GetComponent<Isbad>();
        Bad = isbad;

       




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
            FPS.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Reallygood.destorthis();

            Uibeingshown.SetActive(true);
             //ScoreScritp.ScoreCOP += 1;
             ScoreScritp.ScoreAML -= 1;
          
        }
        if (other.CompareTag("Bad"))
        {
            Bad.bad = true;
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

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
        FPS.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Uibeingshown.SetActive(false);
        Showup = false;
    }
    IEnumerator Appeare()
    {
        yield return new WaitForSeconds(3);
        Uibeingshown.SetActive(true);

    }
    IEnumerator Dissapeare()
    {
        yield return new WaitForSeconds(2);
        Uibeingshown.SetActive(false);

    }


}

