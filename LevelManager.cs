using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//I found a tutoial to help with management but i only needed it for one line of code the rest has been typed by me.

public class LevelManager : MonoBehaviour
{

    public GameObject pauseMenu;
  

    private void Start()
    {
        pauseMenu.SetActive (false); //The pause menu is in active till the pause button is pushed.
    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive (!pauseMenu.activeSelf); //gets the pause menu to show 
        Time.timeScale = (pauseMenu.activeSelf) ? 0 : 1; //this will then pause the game when the pause button is pushed.
    }

    public void ToMenu()
    {
        Time.timeScale = 1; //unpauses the game when it gose back into it
        SceneManager.LoadScene("MainMenu"); //This will load the main menu scene.
    }

    public void RestartLevelBtn(string restartGameLevel)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(restartGameLevel); //This will restart the level that the player is in at that moment.
    }

    public void LoadLvl1()
    {
        SceneManager.LoadScene("BallMazeLvl1"); //in the Level select this will load level one
    }

    public void loadLvl2()
    {
        SceneManager.LoadScene("BallMazeLvl2"); //this will load level two
    }

    public void LoadLvl3()
    {
        SceneManager.LoadScene("BallMazeLvl3"); //this will load level three
    }

}
