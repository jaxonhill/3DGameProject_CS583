using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Bring cursor back
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        StaticStats.Health = 3;
        StaticStats.currentQuestIndex = 0;

        SceneManager.LoadScene("_Home_Village");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
