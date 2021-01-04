using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    
    public GameObject prefabGem;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("hit detected");

            if(collision.tag == "gem"){

                var plus = Instantiate(prefabGem);

                Destroy(this.gameObject);
            }

    }

}
