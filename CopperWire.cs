using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperWire : MonoBehaviour {

    private BallRoll player; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BallRoll>(); //Calls apon the player (Ball) class
    }

    void OnTriggerEnter(Collider col) //when the player enters the colider of the copper wires
    {
        if (col.CompareTag("Player"))  //colider compares with the player and if in the colider
        {
            player.Damage(1); //takes 1 damage leading to a loss of a heart.
        }
    }
}
