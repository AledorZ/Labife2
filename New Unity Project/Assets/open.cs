using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AgarTop")
        {
            Debug.Log("Close");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "AgarTop")
        {
            Debug.Log("Open");
        }
    }
}
