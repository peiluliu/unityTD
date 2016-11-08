using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public bool PauseTheGame = false;
    public Transform menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseTheGame = !PauseTheGame;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Resume();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Exit();
        }

        if (PauseTheGame)
        {
            menu.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
        else if (!PauseTheGame)
        {
            menu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Restart()
    {
        PauseTheGame = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Resume()
    {
        PauseTheGame = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
