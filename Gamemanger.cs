using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{
    private int coin;
    public Text tcoin;
    public static int coingame;

    private int score;
    public Text tScore;
    public static int scoregame;

    private void Update()
    {
        coin = coingame;
        tcoin.text = coin.ToString();

        score = scoregame;
        tScore.text = score.ToString();

        if(Endgame.gameover)
        {
            GameOver();
        }
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;  //Change frame rate value
        Pause();
    }

    public GameObject playButton;
    public GameObject gameOver;
    public GameObject PauseButton;
    public GameObject RestartButton;

    public void Play()  //Set value when start game
    {
        coingame = 0;
        scoregame = 0;

        playButton.SetActive(false);
        gameOver.SetActive(false);
        PauseButton.SetActive(true);
        RestartButton.SetActive(false);

        Time.timeScale = 1f;

        Endgame.gameover = false;
    }

    public void Pause()  //Freeze game in pause mode
    {
        playButton.SetActive(true);
        PauseButton.SetActive(false);
        RestartButton.SetActive(false);

        Time.timeScale = 0f;
    }

    public void GameOver()  //Show game over message and pause game
    {
        gameOver.SetActive(true);
        RestartButton.SetActive(true);

        Time.timeScale = 0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
        Endgame.gameover = false;
    }
}
