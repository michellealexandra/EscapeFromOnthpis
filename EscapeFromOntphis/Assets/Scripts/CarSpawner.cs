using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;

    int carNo;

    public float maxPos = 0.9f;

    public float delayTimer = 1f;

    float timer;

    float delay = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (delay >= 0)
        {
            delay -= Time.deltaTime;
            return;
        }
        else
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Vector3 carPos =
                    new Vector3(transform.position.x,
                        Random.Range(-2.5f, 0.9f),
                        transform.position.z);
                carNo = Random.Range(0, 5);
                Instantiate(cars[carNo], carPos, transform.rotation);
                timer = delayTimer;
            }
        }
    }
}
