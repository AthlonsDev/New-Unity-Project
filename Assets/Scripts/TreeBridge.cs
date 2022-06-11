using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBridge : MonoBehaviour
{
    public GameObject fallingTree;
    public Rigidbody2D rb;
    public Collider2D col;


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            //TODO: Show button to press to perform action
            if (Input.GetButtonDown("Interaction"))
            {
                Debug.Log("Pushes Tree");
                rb.gravityScale = 1f;
                col.isTrigger = false;

            }
        }
    }

}
