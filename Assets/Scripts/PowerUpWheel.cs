using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpWheel: MonoBehaviour 
{
    //TODO:set public variables for ui buttons

    public GameObject player;

private void Update() {
    
    // When controller button is pressed(holding)
    while(Input.GetButtonDown("SkillMenu")) 
    {
        // Old System
        // Pause Game and Move Around Wheel and select buttons instead
        //slow time of the game
        // time.timeScale = 0.2;

        // New System
        // Select skill with directional buttons
        // TODO: Set These names to the correpsonding buttons in the input system
        if(Input.GetButtonDown("Up")) {
            // This selects The Hook 
            player.GetComponent<PowerUp>().selectedItem = "Hook";
        }
        if(Input.GetButtonDown("Right")) {
            // This selects The Attack/Offensive Light
            player.GetComponent<PowerUp>().selectedItem = "Attack";
        }
        if(Input.GetButtonDown("Left")) {
            // This selects The Hiding Mechanism 
            player.GetComponent<PowerUp>().selectedItem = "Hide";
        }
        if(Input.GetButtonDown("Down")) {
            // This selects The Finding Object skill (highlights quest Items so they are visible)
            player.GetComponent<PowerUp>().selectedItem = "Find";
        }
        
    }

}



}