using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void QuitGame(){
        Application.Quit();
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManagement.GetActiveScene().buildIndex - 1);
    }
}
