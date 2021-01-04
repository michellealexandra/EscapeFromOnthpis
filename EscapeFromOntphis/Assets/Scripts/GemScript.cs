using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{

    public int scoreValue;

    private void Start() {
        scoreValue = 0;
    }

    private void Update() {
        //update text score
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "gem"){
        Debug.Log("Gem!!!!!!!!");
        scoreValue += 10;
        // Destroy(gameObject);
        }
    }
}
