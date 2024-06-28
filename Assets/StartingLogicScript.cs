using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartingLogicScript : MonoBehaviour
{
    public TMP_Text highScoreText;

    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("HighScore"));
        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
    }

    public void startGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void sendToHelpScreen()
    {
        SceneManager.LoadScene("HelpScreen");
    }

}
