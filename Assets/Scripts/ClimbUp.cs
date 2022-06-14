using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbUp : MonoBehaviour
{
    public GameObject player;
    public BoxCollider2D trigger;
    public BoxCollider2D col;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            if (Input.GetButtonDown("Climb"))
            {
                col.enabled = true;
                climbUp();
            }
        }
    }


    private void climbUp()
    {
        //Should Play Animation of Player Climbing Up
        //For Now Just Apply Force on y and x axis
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(250f, 500f));
        Debug.Log("ClimbUp");
    }

}
