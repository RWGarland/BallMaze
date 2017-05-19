using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to add this for anything with UI in the camera.

//The hearts UI was outsourced 

public class HUD : MonoBehaviour {

    public Sprite[] HeartSprites;

    public Image HeartUI;
    private BallRoll player; 

	
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BallRoll>();  //This allows the console to know where to get the infomation for the player, this will get the health of the player.
    }
	

	void Update ()
    {
        HeartUI.sprite = HeartSprites[player.curHealth]; //this links the heartsprites images to be realated to the current health of the player, this will then get shown at the top of the screen.
	}
}

