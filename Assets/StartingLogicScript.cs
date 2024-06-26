using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingLogicScript : MonoBehaviour
{ 

    public void startGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
