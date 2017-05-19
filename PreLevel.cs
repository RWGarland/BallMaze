using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PreLevel : MonoBehaviour
{

    void OnTriggerEnter(Collider col) //when the player enters the colider of the black hole
    {
        if (col.CompareTag("Player"))  //colider compares with the player and if in the colider
        {
            SceneManager.LoadScene("BallMazeLvl1"); //I have set this up to loop the levels that have been made so this goes to the first level.
        }
    }

}
