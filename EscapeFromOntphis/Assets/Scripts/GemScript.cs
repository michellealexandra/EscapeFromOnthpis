﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    // public ScoreScript score;
    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // if(collider.gameObject.tag == "gem"){
        Debug.Log("Gem!!!!!!!!");

        SoundManagerScript.PlaySound("gem");
        ScoreScript.gemAmount += 50;
        Destroy (gameObject);
        // }
    }
}
