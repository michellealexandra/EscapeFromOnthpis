using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public GameObject gem;
    public float maxPos = 0.9f;
    public float delayTimer = 5f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
       timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //kalo mau dibkin lebih lama ,kecilin aja ini
        timer -= 0.005f;
        if(timer <= 0){
            Vector3 gemPos = new Vector3(transform.position.x, Random.Range(-2.5f, 0.9f), transform.position.z);
            Instantiate(gem, gemPos, transform.rotation);
            timer = delayTimer;
        }
        
    }
}
