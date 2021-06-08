using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour
{


    public Tutorial welcome;
    public Text Header;
    public Text description;
    public Image background;
    // Start is called before the first frame update
    void Start()
    {
        Header.text = welcome.name;
        description.text = welcome.Discription;
        background.sprite = welcome.background;
    }

    
}
