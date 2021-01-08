using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMusicManager : MonoBehaviour
{
    private static StartMusicManager startMusicManagerInstance;
    private bool playSound;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Update(){
         if(SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1){
            playSound = true;
        }else {
            playSound = false;
        }
        checkSound();
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public void checkSound(){
        if(playSound == true){
             startMusicManagerInstance = this;
        } else {
             Destroy(gameObject);
        }
    }
}
