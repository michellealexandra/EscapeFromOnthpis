using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public void QuitGame(){
        SoundManagerScript.PlaySound("button");
        Application.Quit();
    }

    public void Restart(){
        SoundManagerScript.PlaySound("button");
        ScoreScript.gemAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
