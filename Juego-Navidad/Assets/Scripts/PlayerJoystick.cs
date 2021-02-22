using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Transform player;
    public float runTime;

    public void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x + fixedJoystick.Horizontal * speed, player.position.y + fixedJoystick.Vertical * speed, player.position.z);
    }

    public void Run()
    {
        float aux = speed;
        speed += speed;
        Debug.Log(speed);
       // stopRun(aux);
    }

   //Traté de hacer este script para que sirva como temporizador, pero no lo logré, ahí vele si lo consigues o haces un temporizador con el Timer temporizador  = new Timer (5000ms);
    private void stopRun(float aux)
    {
        float initialRunTime;
        initialRunTime = runTime;
        while (runTime > 0)
        {
            runTime -= Time.deltaTime;
        }
        speed = aux;
        runTime = initialRunTime;
        Debug.Log(aux);
        Debug.Log(runTime);
    }
}