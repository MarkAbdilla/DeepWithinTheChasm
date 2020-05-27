using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Awake()
    {
        int numOfSceneLoaders = FindObjectsOfType<SceneLoader>().Length;
        if(numOfSceneLoaders != 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
