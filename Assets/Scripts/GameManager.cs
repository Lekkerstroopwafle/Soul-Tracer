using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject pauseScreen;

    public bool playerWin;
    public bool playerAlive;

    // Start is called before the first frame update
    void Start()
    {
        playerAlive = true;
        playerWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAlive == false)
        {
            GameOver();

            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
        }

        if (playerWin == true)
        {
            gameOverScreen.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeSelf == false)
        {
            pauseScreen.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.activeSelf == true)
        {
            pauseScreen.SetActive(false);
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
