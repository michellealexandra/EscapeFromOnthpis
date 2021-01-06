using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreHard : MonoBehaviour
{
    public TextMeshProUGUI text;

    public static int highScoreHard;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.chosenLevel == 2)
        {
            text.text = highScoreHard.ToString();
        }
    }
}
