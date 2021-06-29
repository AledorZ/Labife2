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
    GameObject FPS;
    void Start()
    {
        FPS = GameObject.Find("FPSController"); FPS.GetComponentInChildren<Camera>();
        Header.text = Incubator.name;
        description.text = Incubator.Discription;
        background.sprite = Incubator.background;
    }

   
    

    private void OnTriggerEnter(Collider gotHit)
    {
        if (gotHit.CompareTag("Player"))
        {
            FPS.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Uishow.SetActive(true);
            Beingshowned = true;
        }


        
        
    }

    public void Destroyit()
    {
        Destroy(gameObject);
    }

    public void Okbutton()
    {
        FPS.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Beingshowned = false;
        Uishow.SetActive(false);
        Destroyit();
    }
}
