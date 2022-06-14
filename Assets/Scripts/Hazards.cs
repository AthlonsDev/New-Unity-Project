using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    public GameObject player;
    public GameObject Gm;

   
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Gm.GetComponent<Game_Manager>().RespawnPlayer();

    }


}
