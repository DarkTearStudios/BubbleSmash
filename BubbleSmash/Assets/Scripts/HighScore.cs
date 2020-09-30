using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    public float highScore;
    string highScoreKey = "HighScore";
    public Text highScoreText;



    private void Update()
    {
        highScoreText.text = highScore.ToString();
    }

    void Start()
    {
        highScore = PlayerPrefs.GetFloat(highScoreKey, 0);
        
        //use this value in whatever shows the leaderboard.
    }
}
