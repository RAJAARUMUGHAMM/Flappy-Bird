using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

    public AudioSource birdchirp;
    public AudioSource backsound;
    private int toggle=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundToggle()
    {
        if (toggle == 0)
        {
            birdchirp.Pause();
            backsound.Pause();
            toggle = 1;
        }
        else
        {
            birdchirp.Play(0);
            backsound.Play(0);
            toggle = 0;
        }
        
    }
   
}
