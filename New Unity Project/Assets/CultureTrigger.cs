using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultureTrigger : MonoBehaviour
{
    public GameObject Ui;
    GameObject FPS;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Ui.SetActive(true);
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
        Ui.SetActive(false);
        Destroyit();
    }



}
