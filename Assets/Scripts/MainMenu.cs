using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "Level Select";
    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(levelToLoad);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
