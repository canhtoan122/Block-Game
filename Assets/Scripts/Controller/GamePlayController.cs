using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;

    public Text mTxtTime;

    private int mTime = 30;

    //Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Count", 0.0f, 1.0f);
    }
    void Count()
    {
        if (mTime == 0)
        {
            GameOverShowPanel();
            CancelInvoke("Count");
        }
        else
        {
            mTime--;
        }
    }

    //Update is called once per frame
    void Update()
    {
        mTxtTime.text = mTime.ToString();
    }
    void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField]
    private GameObject pausePanel, gameOverPanel;

    public void PauseGameButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OptionButton()
    {
        Application.LoadLevel("Main Menu");
    }

    public void RestartButton()
    {
        gameOverPanel.SetActive(false);
        Application.LoadLevel("Level 1");
    }

    public void GameOverShowPanel()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

}
