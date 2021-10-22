using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource Win;
    public AudioSource lose;

    public AudioSource bad;
    public AudioSource good;
    // Start is called before the first frame update
    public void Winner()
    {
        Win.Play();
    }
    public void Loser()
    {
       lose.Play();
    }
    public void Bad()
    {
        bad.Play();
    }
    public void Good()
    {
        good.Play();
    }
}