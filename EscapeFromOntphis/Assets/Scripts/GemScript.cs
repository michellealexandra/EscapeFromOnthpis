using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public ScoreScript score;

    private void Start() {
        // scoreValue = 0;
    }

    private void Update() {
        //update text score
    }

    // private void OnTriggerEnter2D(Collider2D collider) {
    //     if(collider.gameObject.tag == "gem"){
    //     Debug.Log("Gem!!!!!!!!");


    //     Destroy(this.gameObject);
    //     Destroy(collider.gameObject);

    //     score.AddScore(10);
    //     }
    // }

    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "gem"){
            Debug.Log("Gem!!!!!!!!");

            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);

            score.AddScore(10);
        }
    }
}
