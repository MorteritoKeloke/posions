using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManu : MonoBehaviour
{
    public void GameScerne()
    {
        SceneManager.LoadScene("Game")
    }

    public void CommandsScene()
    (
        SceneManager.LoadScene("Commands")
    )

    public void exit()
    {
        Application.Quit();
    }
}
