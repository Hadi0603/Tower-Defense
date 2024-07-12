using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public string SceneName = "LevelSelect";
    public string nextLevel;
    public int levelToUnlock;
    private void OnEnable()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LevelSelect()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        SceneManager.LoadScene(SceneName);
    }
}
