using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text highScoreText;
    public bool gameIsPaused;
    public Text pauseResumeButtonText;
    public GameObject pauseScreen;
    public Button pauseResumeButton;

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
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
