using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI: MonoBehaviour 
{
    public Animator animator;
    public GameObject player;

    // TODO: Use starpathfinder library to give a path to enemy

    // Different types of enemies:
    // scared of light will follow you(bigger range) - moderatley quick - melee attack  (easy)
    // not scared of light follow path(follow you if in range-small) - can't see but can hear - long range attack - hiding recommended not mak noise (harder)
    // not scared of light and will follow you(bigger range) - can see you in darkness  (hardest)


    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "player")
        {
            // Enemy performs attack - instant death for player
            player.GetComponent<PlayerPosition>().RespawnPlayer();

        }
    }
}