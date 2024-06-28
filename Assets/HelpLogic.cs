using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpLogic : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
