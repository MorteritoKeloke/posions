using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    /*
    public string Game;
    public string Options;
    public string MainMenu;
    public string Controls;
    */
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadCommands()
    {
        SceneManager.LoadScene("Commands");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /*
    public void LoadControls()
    {
        SceneManager.LoadScene(Controls);
    }
    */
}
