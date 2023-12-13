using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathMenu;

    // Start is called before the first frame update
    void Start()
    {
        deathMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticStats.Health == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            deathMenu.SetActive(true);
            Time.timeScale = 0f;
            StaticStats.Health = 3;
        }
    }

    public void Restart()
    {
        StaticStats.Health = 3;
        StaticStats.currentQuestIndex = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Home_Village");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

