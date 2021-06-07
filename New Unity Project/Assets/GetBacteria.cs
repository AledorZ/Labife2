using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBacteria : MonoBehaviour
{



    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Pickupable")
        {
            BacteriaSript bacteria = GameObject.Find("Swap").GetComponent<BacteriaSript>();
            gameObject.GetComponent<BacteriaSript>();

            if (bacteria.bacteriaison == false) {
                Debug.Log("In");
            }
            
            }

           
        }
    }


   