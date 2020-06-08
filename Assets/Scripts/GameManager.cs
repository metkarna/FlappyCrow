using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameStartCanvas;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        gameStartCanvas.SetActive(false);
        scoreCanvas.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
