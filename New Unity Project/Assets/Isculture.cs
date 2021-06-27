using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isculture : MonoBehaviour
{
    [SerializeField] bool iscultured = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CottonTip") 
        {
            iscultured = true;
            if(iscultured == true)
            {
                Debug.Log("isCultured");
            }
        }
    }

}
