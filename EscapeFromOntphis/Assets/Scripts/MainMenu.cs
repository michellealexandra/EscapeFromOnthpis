using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SoundManagerScript.PlaySound("button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){
        SoundManagerScript.PlaySound("button");
        Application.Quit();
    }

    public void Restart(){
        SoundManagerScript.PlaySound("button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
