using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text TextWin;
    public Text TextScore;
    public Image ImageBackground;
    public RectTransform PanelContainer;
    public int ScoreToWin; // so enemy can giet de win
    public int Score;

    // Duoc goi khi lan dau game object duoc active
    void Awake()
    {
        // Debug.Log("Awake");
        GameManager.ScoreController = this;

        PanelContainer.gameObject.SetActive(false);
    }

    // Duoc goi khi script lan dau tien duoc enable
    void Start()
    {
        // Debug.Log("Start");
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
        PanelContainer.gameObject.SetActive(true);
    }
}
