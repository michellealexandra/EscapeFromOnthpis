﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public void QuitGame(){
        Application.Quit();
    }

    public void Restart(){
        ScoreScript.gemAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
