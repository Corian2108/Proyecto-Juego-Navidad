using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float visionRadius;
    public float speed;
    public float damage;
    public bool estaMuerto;

    Rigidbody2D enemyBody;
    GameObject player;
    Vector3 initialPosition;
    VidaJugador playerVida;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerVida = player.GetComponent<VidaJugador>();
        enemyBody = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 target = initialPosition;

        float distance = Vector3.Distance(player.transform.position, transform.position);

        if(distance < visionRadius) 
        {
            target = player.transform.position;
        } else {
            target = initialPosition;
        }

        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

        if (estaMuerto)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.name == "Player")
        {
            playerVida.damaged(damage);
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.gameObject.name);
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, visionRadius);    
    }
}
