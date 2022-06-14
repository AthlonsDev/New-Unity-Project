using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Ignore Collisions
        if(collision.collider.tag == "Ignore")
        {
            Debug.Log("Ignore This Object");
            Physics2D.IgnoreCollision(collision.collider.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }

}
