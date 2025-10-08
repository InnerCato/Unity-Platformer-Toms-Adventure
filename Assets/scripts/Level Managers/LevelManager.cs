using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int levelsUnlocked;
    bool isPaused = false;
    public GameObject pauseMenuUI;

    public void NextLevel()
    {
        levelsUnlocked++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Level1()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void Level3()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
    public void Level4()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }
    public void Level5()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

    public void End()
    {
        SceneManager.LoadScene("End");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Continue()
    {

    }

    public void SelectLevel()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Levelselection");
    }

    public void NewGame()
    {
        Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("game is quitting...");
        Application.Quit();
    }

    public void pauseGame()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
}
