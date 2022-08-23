using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp: MonoBehaviour {

    public GameObject player;
    public string selectedItem;

    private void Update() 
    {
        //Get Name of Selected Power Up from wheel
        if (selectedItem == "Hook") 
        {
            selectedItem = "Hook";
        }
        if (selectedItem == "Attack")
        {
            selectedItem = "Attack";
        }
        if (selectedItem == "Find")
        {
            selectedItem = "Find";
        }
        if (selectedItem == "Hide")
        {
            selectedItem = "Hide";
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hooking" && selectedItem == "hook")
        {
            useHook();
        }
    }

    void useHook() {
        if(Input.GetButtonDown("Shoot")) 
        {
            // TODO: Shoot hook from light thing to hook spot
            // use prefab or raycast
            // Then swing player horizontally
        }
    }




}