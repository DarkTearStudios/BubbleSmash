using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{



    public static ScoreManager instance;
    public float score;
    public float highScore = 0;
    string highScoreKey = "HighScore";
    public Text scoreText;






    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat(highScoreKey, 0);

    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = score.ToString();
    }

    public void IncrementScore()
    {
        score += 0.5f;

    }

    public void StopScore()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetFloat(highScoreKey, score);
            PlayerPrefs.Save();
        }



    }
}



