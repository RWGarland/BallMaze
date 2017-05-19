using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I looked at loads of things to get this to work but most either didnt work or were far too complicated, so i eventualy just typed it myself to get it to work the way i wanted 

public class Sparks : MonoBehaviour {

    public ParticleSystem sparks;

    void OnTriggerEnter(Collider col) //When the ball hits a collider

    {
        sparks.Play(); //plays the particles when it enters a colider on the copper wires
    }

}
