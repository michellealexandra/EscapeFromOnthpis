using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Easy()
    {
        SoundManagerScript.PlaySound("button");
        ScoreScript.chosenLevel = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Hard()
    {
        SoundManagerScript.PlaySound("button");
        ScoreScript.chosenLevel = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Back()
    {
        SoundManagerScript.PlaySound("button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
