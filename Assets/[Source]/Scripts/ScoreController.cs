using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text TextWin;
    public Text TextScore;
    public Image ImageBackground;
    public int ScoreToWin; // so enemy can giet de win
    public int Score;

    void Awake()
    {
        GameManager.ScoreController = this;

        ImageBackground.gameObject.SetActive(false);
        TextWin.gameObject.SetActive(false);
        TextScore.gameObject.SetActive(false);
    }

    public void AddScore(int scoreToAdd)
    {
        Score += scoreToAdd;
        TextScore.text = Score.ToString();

        if (Score >= ScoreToWin)
        {
            GameManager.OnReachGoal();
        }
    }

    public void ShowWinning()
    {
        ImageBackground.gameObject.SetActive(true);
        TextWin.gameObject.SetActive(true);
        TextScore.gameObject.SetActive(true);
    }
}
