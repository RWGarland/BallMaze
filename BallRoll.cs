using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

//The ability for the ball to use the acceliromiter has been taken from other sourses, it has been referenced
//The health of the player has also been referenced 

public class BallRoll : MonoBehaviour
{

    public int curHealth;
    public int maxHealth = 100; //Sets the maximum health to 100 or the console says it is out of range

    public GameObject gameOverMenu;
    public bool isFlat = true; 
    private Rigidbody rigid;
    private void Start()

    {
        curHealth = maxHealth;
        rigid = GetComponent<Rigidbody>();
        gameOverMenu.SetActive(false);
    }
    private void Update()
    {
        Vector3 tilt = Input.acceleration; //This allows the acceleromitor to move the ball around the board.


        if (isFlat) //if the phone is flat (on its back)
            tilt = Quaternion.Euler(90, 0, 0) * tilt; //This is controling the ball to move by using the acceliromitor. 
        //This quaternion has been changed so it now works that the phone is now 90' on the X axis, this allows the ball to move

        rigid.AddForce(tilt); 

        if(curHealth > maxHealth) //Sets the curents health to the same value as the maximun health at the bagining of the game
        {
            curHealth = maxHealth;
        }
        if(curHealth <= 0)
        {
            Die (); //When the players health reaches 0 then it passes over to void die to act the game over screen
        }
    }

    void Die() // i wrote the death and the menu funtions 
    {
        Destroy(this.gameObject); //when the ball runs out of hearts the ball gets destroyed
        gameOverMenu.SetActive(true); //this will activate the game over screen when the ball dies
        /*Time.timeScale = (gameOverMenu.activeSelf) ? 0 : 1;*/ // i origenaly had it freeze time like the pause menu but it wouldn't un freeze, so i chose to destroy the ball instead.
    }

    public void Damage(int dmg)
    {
        curHealth -= dmg; //lets the player take damage
    }
}
     
