using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inkubator : MonoBehaviour
{
    public Tutorial Incubator;
    public Text Header;
    public Text description;
    public Image background;
    public GameObject Uishow;
    public bool Beingshowned = true;
    
    void Start()
    {
        Header.text = Incubator.name;
        description.text = Incubator.Discription;
        background.sprite = Incubator.background;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
