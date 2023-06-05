using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour
{
    public string Game;
    public string MainMenu;
    public string Commands;

    public void LoadGame()
    {
        SceneManager.LoadScene(Game);
    }

    public void LoadCommands()
    {
        SceneManager.LoadScene(Commands);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
