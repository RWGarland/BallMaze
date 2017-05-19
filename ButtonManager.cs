using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

//Used from other bits of code typed for this game

public class ButtonManager : MonoBehaviour {

    public GameObject controlsMenu;
    public GameObject levelSelect; //Allows me to see the menus i need.

    private void Start()
    {
        controlsMenu.SetActive(false);
        levelSelect.SetActive(false); //Puts the Two menus out  of action until the button is clicked for them to show.
    }

    public void ToggleContolMenu()
    {
        controlsMenu.SetActive(!controlsMenu.activeSelf); //This will toggle the controls menu when the controls button is pushed in the home menu
    }

    public void ToggleLevelSelect()
    {
        levelSelect.SetActive(!levelSelect.activeSelf); //This will toggle the level select menu so the player can choose a level if they didnt want to play through the whole thing.
    }

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel); //This starts a new game by loading a new level (Level One).
    }

    public void ExitGameBtn()
    {
        Application.Quit(); //This will then quit the application when pushed.
    }

}
