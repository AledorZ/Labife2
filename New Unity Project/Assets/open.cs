using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    [SerializeField] bool isopned;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AgarTop")
        {
            clousedtop();
            Debug.Log("Close");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "AgarTop")
        {

            Openedtop();
            Debug.Log("Open");
        }
    }

  public  void Openedtop()
    {
        isopned = true;
    }
    public void clousedtop()
    {
        isopned = false;
    }


}
