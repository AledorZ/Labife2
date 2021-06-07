using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncubatorScript : MonoBehaviour
{
    public Transform agar1, agar2, agar3, agar4;
    public float FinishTempreture;
    public bool Agar;
   
    void Start()
    {

    }


    

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Pickupable")
        {
            BacteriaSript bacteria = GameObject.Find("Swap").GetComponent<BacteriaSript>();
            gameObject.GetComponent<BacteriaSript>();
            Agar = true;
            
            
        }


        
    }

    void Update()
    {
        if(Agar == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("CanPlaceAgar");
            }
        }
        else
        {
            return;
        }
    }
}
