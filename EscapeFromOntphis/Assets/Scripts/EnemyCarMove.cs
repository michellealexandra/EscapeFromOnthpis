﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMove : MonoBehaviour
{
    public float speed =8f;
    float destroyer = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);

        if (transform.localPosition.x < destroyer)
        {
            Destroy(this.gameObject);
        }

    }
}
