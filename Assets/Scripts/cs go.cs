using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLights : MonoBehaviour
{
    Light spotLight;
    AudioSource audio;
    public AudioClip bip;
    void Start()
    {
        spotLight = GetComponent<Light>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(spotLight.enabled == false)
            {
                spotLight.enabled = true;
                audio.PlayOneShot(bip);
            }
            else
            {
                spotLight.enabled = false;
            }
        }
    }
}
