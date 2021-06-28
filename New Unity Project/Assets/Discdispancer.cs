using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discdispancer : MonoBehaviour

{
   
    public GameObject disc1, disc2, disc3, disc4, disc5;

    void Start()
    {
        disc1.SetActive(false);
        disc2.SetActive(false);
        disc3.SetActive(false);
        disc4.SetActive(false);
        disc5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Rigidbody>().isKinematic)
        {
            Debug.Log("Cool");
           
            
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        Setdist();
         
            }
        }

    }
    void Setdist()
    {
        disc1.SetActive(true);
        disc2.SetActive(true);
        disc3.SetActive(true);
        disc4.SetActive(true);
        disc5.SetActive(true);
    }

    
}
