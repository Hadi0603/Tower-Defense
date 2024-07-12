using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameIsOver;
    public GameObject gameOverUI;
    public GameObject levelCompleteUI;
    
    private void Start()
    {
        gameIsOver = false;
    }
    void Update()
    {
        if (gameIsOver == true)
        {
            return;
        }
        if (PlayerStats.lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }
    public void WinLevel()
    {
        gameIsOver = true;
        levelCompleteUI.SetActive(true);
    }
}
