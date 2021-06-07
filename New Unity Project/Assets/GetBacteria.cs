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
        if (col.gameObject.name == "Swap")
        {
            //BacteriaSript bacteria = GameObject.Find("Swap").GetComponent<BacteriaSript>();
            BacteriaSript bacteria = gameObject.GetComponent<BacteriaSript>();

            if (bacteria.bacteriaison == false)
            {
                Debug.Log("GotIt");

            }
        }
    }
}

   