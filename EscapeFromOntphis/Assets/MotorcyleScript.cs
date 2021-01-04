using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorcyleScript : MonoBehaviour
{

    public float motorSpeed;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.y += Input.GetAxis ("Vertical") * motorSpeed * Time.deltaTime;

        transform.position = position;
    }
}
