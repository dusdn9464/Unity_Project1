using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //유니티엔진의 GUI에 접근가능
using TMPro;                //텍스트메시프로 사용시

public class AddScore : MonoBehaviour
{
    //싱글톤 만들기
    //public static AddScore instance;
    //private void Awake() => instance = this;

    public static AddScore instance = null;


    int score = 0;
    int highScore = 0;
    public Text scoreTxt;           //일반 UI 텍스트
    public Text highScoreTxt;         //일반 UI 텍스트
    public TextMeshProUGUI textTxt;     //텍스트메시프로

    public GameObject gameOverPanel;
    public Text gameOverScore;
    public Text gameOverHighScore;
    int OverScore;
    int OverHighScore;

    public GameObject boss;


    private void Awake() => instance = this;
    

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreTxt.text = "HighScore\n" + highScore.ToString("0");
    }

    private void Update()
    {
        if (gameOverPanel.activeSelf == true)
        {
            //OverScore = PlayerPrefs.GetInt("KILL_COUNT");
            gameOverScore.text = score.ToString("");
            OverHighScore = PlayerPrefs.GetInt("HighScore");
            gameOverHighScore.text = OverHighScore.ToString("");
        }

        //보스 등장
        if(score > 5)
        {
            boss.SetActive(true);
            
        }
    }

    public void KillScore()
    {
        //score++;
        //scoreTxt.text = "Score : " + score;
        

        ++score;
        scoreTxt.text = "Score\n" + score.ToString("0");
        //PlayerPrefs.SetInt("KILL_COUNT", score);

        if (score > highScore)
        {
            ++highScore;
            highScoreTxt.text = "HighScore\n" + highScore.ToString("");
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
