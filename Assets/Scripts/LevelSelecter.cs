using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelecter : MonoBehaviour
{
    public Button[] levelButtons;
    public Color enabledColour = Color.white;
    public Color disabledColour = Color.white;
    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for(int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
                levelButtons[i].image.color = disabledColour;
            }
            else
            {
                levelButtons[i].interactable = true;
                levelButtons[i].image.color = enabledColour;
            }
        }
    }
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
