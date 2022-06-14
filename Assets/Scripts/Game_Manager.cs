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
        //Updates Checkpoint Location
        NewPosition = position;

    }

    public void RespawnPlayer()
    {
        //Respawns Player at Checkpoint
        player.transform.position = NewPosition;

    }


    }
