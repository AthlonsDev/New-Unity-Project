using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBridge : MonoBehaviour
{
    public GameObject fallingTree;
    public Rigidbody2D rb;
    public Collider2D col;
    public CircleCollider2D trigger;


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            //TODO: Show button to press to perform action
            if (Input.GetButtonDown("Interaction"))
            {
                Debug.Log("Pushes Tree");
                rb.gravityScale = 1f;
                col.enabled = true;
                //TODO: Add a Force to Push it
                rb.AddForce(new Vector2(100f, 0));
                // disable trigger collider
                trigger.enabled = false;

            }
        }
    }

}
