using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    public GameObject player;

   
    private void OnCollisionEnter2D(Collision2D collision)
    {

        player.GetComponent<PlayerPosition>().RespawnPlayer();

    }


}
