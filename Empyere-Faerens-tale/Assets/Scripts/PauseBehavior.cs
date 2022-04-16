using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehavior : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool ispaused;


    void Start()
    {
        pauseScreen.SetActive(false);
    }
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            if (ispaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }




    }
    public void PauseGame()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void GOtoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

