using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float visionRadius;
    public float speed;
    public float damage = -2.5f;
    public bool estaMuerto;

    Rigidbody2D enemyBody;
    GameObject player;
    Vector3 initialPosition;
    VidaJugador playerVida;
    WeaponController palyerAttack;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerVida = player.GetComponent<VidaJugador>();
        palyerAttack = player.GetComponent<WeaponController>();
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

        if (estaMuerto == true)
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

    private void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.name == "Player" && palyerAttack.municion != 100)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, visionRadius);    
    }
}
