using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp: MonoBehaviour {

    public GameObject player;
    string selectedItem;

    private void Update() 
    {
        //Get Name of Selected Power Up from wheel
        if (selectedItem == "Hook") 
        {
            selectedItem = "hook";
        }
    }

    OnTriggerStay2D(collider collider) {
        if(collider.tag == "hooking" && selectedItem == "hook")
        {
            useHook();
        }
    }

    void useHook() {
        if(input.GetButtonDown("Shoot")) 
        {
            // TODO: Shoot hook from light thing to hook spot
            // use prefab or raycast
            // Then swing player horizontally
        }
    }

}