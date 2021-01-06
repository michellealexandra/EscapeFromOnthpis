using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public GameObject[] gems;
    int gemNo;
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
        timer -= 0.002f;
        if(timer <= 0){
            Vector3 gemPos = new Vector3(transform.position.x, Random.Range(-2.5f, 0.9f), transform.position.z);
            float randomChance = Random.Range(0.0f, 1.0f);
            if(randomChance < 0.4f){
                 Instantiate(gems[0], gemPos, transform.rotation);
            }
            else{
                Instantiate(gems[1], gemPos, transform.rotation);
            }
            timer = delayTimer;
        }
        
    }
}
