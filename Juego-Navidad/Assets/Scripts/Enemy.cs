using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float visionRadius;
    public float speed;
    public Rigidbody2D playerBody;
    public int damage;
    public float damageaTime;
    float currentDamageTime;

    GameObject player;
    Vector3 initialPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 target = initialPosition;

        float distance = Vector3.Distance(player.transform.position, transform.position);
        if(distance < visionRadius) 
        {
            target = player.transform.position;
            playerBody.bodyType = RigidbodyType2D.Dynamic;
        } else {
            target = initialPosition;
            playerBody.bodyType = RigidbodyType2D.Kinematic;
        }

        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, visionRadius);    
    }
}
