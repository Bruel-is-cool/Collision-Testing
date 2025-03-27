using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            { 
            
        ResumeGame();
            }
            else PauseGame();
        }
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log(isPaused);
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log(isPaused);
    }

    public void QuitGame()
    {   
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Quitting the game");
        Application.Quit();
    }
}
