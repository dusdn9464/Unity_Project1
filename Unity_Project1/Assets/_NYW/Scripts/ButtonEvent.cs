using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject score;

    public void OnStartButtonClick()
    {
        SceneMgr.Instance.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void OnMenuButtonClick()
    {

    }

    public void OnOptionButtonClick()
    {

    }

    public void OnPauseButtonClick()
    {
        pauseMenu.SetActive(true);
        //일시정지 활성화
        Time.timeScale = 0;
    }

    public void OnResumeButtonClick()
    {
        //일시정지 비활성화
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnQuitButtonClick()
    {
        //SceneMgr.Instance.LoadScene("StartScene");
        pauseMenu.SetActive(false);
        score.SetActive(true);
    }

    public void OnXButtonClick()
    {
        SceneMgr.Instance.LoadScene("StartScene");
    }

}
