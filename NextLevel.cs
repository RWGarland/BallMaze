using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

        void OnTriggerEnter(Collider col) //when the player enters the colider of the black hole
    {
            if (col.CompareTag("Player"))  //colider compares with the player and if in the colider
            {
                SceneManager.LoadScene("BallMazeLvl2"); // it will then load up level 2 when the player enters the collider.
            }
        }
        
    }
