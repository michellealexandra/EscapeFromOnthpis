﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip gemSFX, crashSFX;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        gemSFX = Resources.Load<AudioClip>("gem");
        crashSFX = Resources.Load<AudioClip>("crash");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "gem":
                audioSrc.PlayOneShot (gemSFX);
                break;
            case "crash":
                audioSrc.PlayOneShot (crashSFX);
                break;
        }
    }
}
