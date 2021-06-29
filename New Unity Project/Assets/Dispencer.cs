using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispencer : MonoBehaviour
{
    public GameObject Message;
    GameObject FPS;
    // Start is called before the first frame update
    void Start()
    {
        Message.SetActive(false);
        FPS = GameObject.Find("FPSController"); FPS.GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider gotHit)
    {
        if (gotHit.CompareTag("Player"))
        {
            Message.SetActive(true);
            FPS.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
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
        Message.SetActive(false);
        Destroyit();
    }



}

