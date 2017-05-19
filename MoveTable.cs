using UnityEngine;
using System.Collections;

//This has been given to me by Richard, I have re-added this to my game so it can be controled through the WebGL, the game mainly works on the mobile through the acceliromiter 

public class MoveTable : MonoBehaviour
{

    [Range(1f, 100f)]
    public float Speed = 10f;

    void Update()
    {
        float tX = transform.rotation.eulerAngles.x; //allows it to use the x,y and z axis
        float tY = transform.rotation.eulerAngles.y;
        float tZ = transform.rotation.eulerAngles.z;
        //This allows the Plane to turn using the arrow keys of the keyboard
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tX += Time.deltaTime * 10; //this goes at the speed of 10 to make the ball roll in that direction
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tX -= Time.deltaTime * 10; //this goes at the speed of 10 to make the ball roll in that direction
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tZ += Time.deltaTime * 10; //this goes at the speed of 10 to make the ball roll in that direction
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tZ -= Time.deltaTime * 10; //this goes at the speed of 10 to make the ball roll in that direction
        }
        transform.rotation = Quaternion.Euler(tX, tY, tZ);
    }
}
 


