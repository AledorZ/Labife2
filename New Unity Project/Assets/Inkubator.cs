using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Inkubator : MonoBehaviour
{
    public Tutorial Incubator;
    public Text Header;
    public Text description;
    public Image background;
    public GameObject Uishow;
    public bool Beingshowned = false;
    
    void Start()
    {
        Header.text = Incubator.name;
        description.text = Incubator.Discription;
        background.sprite = Incubator.background;
    }

    // Update is called once per frame
    void Update()
    {
        if(Beingshowned == true)
        {
            FirstPersonController FPS = GameObject.Find("FPSController").GetComponent<FirstPersonController>();

            FPS.m_MouseLook.SetCursorLock(false);
            FPS.m_MouseLook.UpdateCursorLock();
        }
        else
        {
            FirstPersonController FPS = GameObject.Find("FPSController").GetComponent<FirstPersonController>();

            FPS.m_MouseLook.SetCursorLock(true);
            FPS.m_MouseLook.UpdateCursorLock();
        }
    }

    private void OnTriggerEnter(Collider gotHit)
    {
        if (gotHit.CompareTag("Player"))
        {
            Uishow.SetActive(true);
            Beingshowned = true;
        }


        
        
    }

    public void Okbutton()
    {
        Beingshowned = false;
        Uishow.SetActive(false);
    }
}
