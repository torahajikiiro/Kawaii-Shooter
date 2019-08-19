using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text TextWin;
    public Text TextScore;
    public Image ImageBackground;
    public int EnemyCountToWin; // so enemy can giet de win
    public int DeadCount;

    void Awake()
    {
        ImageBackground.gameObject.SetActive(false);
        TextWin.gameObject.SetActive(false);
        TextScore.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DeadCount >= EnemyCountToWin)
        {
            ImageBackground.gameObject.SetActive(true);
            TextWin.gameObject.SetActive(true);
            TextScore.gameObject.SetActive(true);

            TextScore.text = DeadCount.ToString();
        }
    }
}
