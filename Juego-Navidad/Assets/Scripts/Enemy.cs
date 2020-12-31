using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float visionRadius;
    public float speed;

    GameObject player;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;

        float distance = Vector3.Distance(player.transform.position, transform.position);
        if(distance < visionRadius) target = player.transform.position;

        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

        Debug.DrawLine(transform.position, target, Color.green);
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, visionRadius);    
    }
}
