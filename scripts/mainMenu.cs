using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/ingame", LoadSceneMode.Single);
    }

    public void GoToOptions()
    {
        SceneManager.LoadScene("Scenes/options", LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
        print("app quit");
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("scenes/main menu", LoadSceneMode.Single);
    }
}
