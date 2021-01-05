using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    int score = 0;
    int gemCollected = 0;
    public GameObject gem;
    public Text txtScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        //menampilkan di UI
        txtScore.text = score + "";
    }
}
