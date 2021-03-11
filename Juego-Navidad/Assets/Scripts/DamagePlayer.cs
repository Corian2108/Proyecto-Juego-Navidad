using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    VidaJugador jugadorVida;

    public int damage;
    public float damageTime;
    float currentDamageTime;
    void Start()
    {
        /*Esto sirve*/
        jugadorVida = GameObject.FindWithTag("Player").GetComponent<VidaJugador>();
    }

    /*Esto no está funcionando*/
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(jugadorVida.vida);
        currentDamageTime += Time.deltaTime;
        Debug.Log("Está contando el tiempo");
        if (currentDamageTime > damageTime)
        {
            jugadorVida.vida += damage;
            currentDamageTime = 0.0f;
            Debug.Log("Está haciendo daño");
        }
    }


}
