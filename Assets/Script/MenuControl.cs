using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
   public void PlayButton1()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit() {
        Debug.Log("çýktý");
        Application.Quit();

     }
    public void MenuExit()
    {
        SceneManager.LoadScene(0);
    }
    public void Ressart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
