using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHoldInPlace : MonoBehaviour {

    Quaternion rotation;
    void Awake()
    {
        rotation = transform.rotation; //This holds the particle effect in place while the ball rolls around.
    }
    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
