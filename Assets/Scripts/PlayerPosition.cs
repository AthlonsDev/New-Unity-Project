using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    public Game_Manager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<Game_Manager>();

        transform.position = gm.lastCheckpointPosition;

        Debug.Log(transform.position = gm.GetComponent<Game_Manager>().lastCheckpointPosition);

    }

    public void RespawnPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
