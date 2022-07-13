using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController: MonoBehaviour {

    public GameObject player;
    public CharacterController2D controller;
    bool canClimb = false;
    public float speed = 1f;
    


    OnTriggerEnter2D(Collider2D collision) 
    {
    
    if(collision.tag == "player") {
    
    //pressing interact to climb
        if(Input.GetButtonDown("Interaction")) {
            canClimb = true;
        }
    }
    }

    OnTriggerStay2D(Collider2D collider) {
        if(collision.tag == "player") {
            if (canClimb == true) {
                // pressing interact to get off from ladder
               if(Input.GetButtonDown("Interaction")) {
                 canClimb = false;
                }            
            }
        }
    }

    void FixedUpdate() 
    {
        if(canClimb == true) {
        // translate movement from horizontal to vertical
            float climbing = Input.GetAxisRaw("LeftH") * speed;
            controller.Move(false, false, climbing * Time.fixedDeltaTime);
        }
    }   
}