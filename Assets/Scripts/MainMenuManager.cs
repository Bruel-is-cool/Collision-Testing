using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
   public void LoadScene(string Level)
   {
        SceneManager.LoadScene(Level);
   }

   public void QuitGame()
   {
        Application.Quit();
   }
}
