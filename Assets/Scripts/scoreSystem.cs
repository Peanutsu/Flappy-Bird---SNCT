using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditorInternal.Profiling.Memory.Experimental;

public class scoreSystem : MonoBehaviour
{
    public static scoreSystem instance;
    public BoxCollider2D canos;
    public int score;
    public int bestScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score = 0;
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
        UpdateBestScore();
        scoreText.text = score.ToString();
        bestScoreText.text = bestScore.ToString();

    }

    // Update is called once per frame
    void Update()
    { 
        UpdateBestScore();
    }

    public void UpdateBestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            bestScoreText.text = score.ToString();
            PlayerPrefs.SetInt("bestScore", score);
        }   
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
