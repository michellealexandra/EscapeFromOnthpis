using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenu : MonoBehaviour
{
    public void Easy()
    {
         ScoreScript.chosenLevel = 1;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Hard()
    {
         ScoreScript.chosenLevel = 2;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Back()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
