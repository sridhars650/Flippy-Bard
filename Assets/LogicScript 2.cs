using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public TMP_Text highScoreText;
    public bool gameIsPaused;
    public Text pauseResumeButtonText;
    public GameObject pauseScreen;
    public GameObject pauseResumeButton;
    public bool gameIsOver;
    
    public void Start()
    {
        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pauseResumeButton.SetActive(true);
        gameIsOver = false;
    }

    public void gameOver()
    {
        gameIsOver = true;
        gameOverScreen.SetActive(true);
        pauseResumeButton.SetActive(false);

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsOver)
            {
                pauseGame();
                if (gameIsPaused)
                {
                    pauseScreen.SetActive(true);
                }
                else
                {
                    pauseScreen.SetActive(false);
                }
            }
        }
    }

    public void buttonPause()
    {
        pauseGame();
        if (gameIsPaused)
        {
            pauseScreen.SetActive(true);
        }
        else
        {
            pauseScreen.SetActive(false);
        }
    }

    public void pauseGame()
    {
        gameIsPaused = !gameIsPaused;
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pauseResumeButtonText.text = "▶";
            pauseResumeButtonText.fontSize = 150;
        }
        else
        {
            Time.timeScale = 1;
            pauseResumeButtonText.text = "▐▐";
            pauseResumeButtonText.fontSize = 50;
        }

    }

    public void quitGame()
    {
        Application.Quit();
    }
}
