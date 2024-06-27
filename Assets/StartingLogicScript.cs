using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingLogicScript : MonoBehaviour
{
    public Text highScoreText;

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


}
