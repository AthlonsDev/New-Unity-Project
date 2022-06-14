using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject gameMaster;

    private void Start()
    {
       // SetCheckpoint();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            SetCheckpoint();
        }

    }

    private void SetCheckpoint()
    {

        Vector2 checkposition = new Vector2(transform.position.x, transform.position.y);

        gameMaster.GetComponent<Game_Manager>().UpdateCheckpoint(checkposition);

        //Debug.Log(checkposition);

    }
}
