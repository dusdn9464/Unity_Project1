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

    public int killCount;
    public int record;                 //최고기록
    public Text killCountTxt;           //일반 UI 텍스트
    public Text recordCountTxt;         //일반 UI 텍스트
    public TextMeshProUGUI textTxt;     //텍스트메시프로 

    //int score = 0;
    //int highScore = 0;

    private void Awake()
    {
        //하이스코어 불러오기
        //highScore = PlayerPrefs.GetInt("HighScore");
        //highScoreTxt.text = "HighScore : " + highScore;

        LoadGameData();
        if (instance == null) instance = this;
        else if (instance != this) Destroy(this.gameObject);
        DontDestroyOnLoad(gameObject);
    }

    private void LoadGameData()
    {
        record = PlayerPrefs.GetInt("KILL_COUNT", 0);
        recordCountTxt.text = "HIGHSCORE : " + record.ToString("0");
    }

    private void Update()
    {
        //하이스코어
        //SaveHighScore();
    }

    public void KillScore()
    {
        //score++;
        //scoreTxt.text = "Score : " + score;
        

        ++killCount;
        killCountTxt.text = "SCORE : " + killCount.ToString("0");
        PlayerPrefs.SetInt("KILL_COUNT", killCount);

        if (killCount > record)
        {
            ++record;
            recordCountTxt.text = "HIGHSCORE : " + record.ToString("");
            PlayerPrefs.SetInt("KILL_COUNT", record);
        }
    }

    ///void SaveHighScore()
    ///{
    ///    if(score > highScore)
    ///    {
    ///        HighScore = score;
    ///        PlayerPrefs.SetInt("HighScore", highScore);
    ///        highScoreTxt.text = "HighScore" + HighScore;
    ///    }
    ///}
}
