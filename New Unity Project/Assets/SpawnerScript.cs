using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Agar;
    bool canspawn;
    public Transform tranfre;


    void Start()
    {

    }


    void Update()
    {
        if(canspawn== true)
        {
            Debug.Log("HesHere");
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Pickup pck = GameObject.Find("FPSController").GetComponent<Pickup>();
            


        }
    }
}
