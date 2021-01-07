using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MotorcyleScript : MonoBehaviour
{
    public float motorSpeed;

    Vector3 position;

    public float maxPos = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.y += Input.GetAxis("Vertical") * motorSpeed * Time.deltaTime;

        position.y = Mathf.Clamp(position.y, -2.5f, 0.9f);

        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car")
        {
            SoundManagerScript.PlaySound("crash");
            Destroy (gameObject);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager
                    .LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager
                    .LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
