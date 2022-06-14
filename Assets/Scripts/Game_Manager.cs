using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public GameObject player;
    private Vector2 newPosition;
    public Vector2 NewPosition { get => newPosition; set => newPosition = value; }


    public void UpdateCheckpoint(Vector2 position)
    {

        NewPosition = position;

    }
    public void RespawnPlayer()
    {

        player.transform.position = NewPosition;
    }

    private void FixedUpdate()
    {
        Debug.Log("New Checkpoints is: " + NewPosition);
    }


}