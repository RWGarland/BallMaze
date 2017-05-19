using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour {

    public Transform target;


    void Update()
    {
        {
            transform.LookAt(target); // This allows the camera to always be looking at the player i.e the ball while it is moving round the board.
        }
    }
}
