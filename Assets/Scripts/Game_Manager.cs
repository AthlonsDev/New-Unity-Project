using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    private static Game_Manager instance;
    public Vector2 lastCheckpointPosition;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(lastCheckpointPosition);
        }
    }

}