using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TestScore : MonoBehaviour
{
    public float TimerToWin = 0.0f;
    [SerializeField] bool Agarisin = false;
    public Tutorial Final;
    public Text Header;
    public Text description;
    public Image background;
    public bool Showup = true;
    public GameObject Uibeingshown;


    // Start is called before the first frame update
    void Start()
    {
        Header.text = Final.name;
        description.text = Final.Discription;
        background.sprite = Final.background;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Agarisin == true)
        {
            Timer();
        }


        if (Showup == true)
        {
            gameMasterscipt GM = GameObject.Find("GameMaster").GetComponent<gameMasterscipt>();
            GM.Pause();
        }

        else
        {
            gameMasterscipt GM = GameObject.Find("GameMaster").GetComponent<gameMasterscipt>();
            GM.unpause();
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
            Showup = true;
            Uibeingshown.SetActive(true);
           
            ScoreScritp.ScoreCOT = +1;
        }
        
    }
    public void Okdokie()
    {
        Uibeingshown.SetActive(false);
        Showup = false;
    }
}

