using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Transform player;

    public void FixedUpdate() 
    {
        transform.position = new Vector3 (player.position.x + fixedJoystick.Horizontal*speed, player.position.y + fixedJoystick.Vertical*speed, player.position.z);
        //transform.rotation = new Vector3 (player.rotation.x * 0, player.rotation.y * 0, player.rotation.z * 0);
    }
}