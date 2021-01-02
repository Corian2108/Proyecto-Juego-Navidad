using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject player;

    public float runtime;

    public void Run()
    {
        float playerSpeed = player.GetComponent<PlayerJoystick>().speed;
        playerSpeed = playerSpeed * 2;
        if (runtime <= 0)
        {
            playerSpeed = playerSpeed / 2;
        }
        else
        {
            runtime -= Time.deltaTime;
            Debug.Log(runtime);
            Run();
        }
    }

    void Attack()
    {

    }
}
