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
    }
}