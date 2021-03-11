using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Button : MonoBehaviour
{
    Player PlayerMove;
    public AudioSource clip;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMove = GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    //Acción derecha
    public void derechaON()
    {
        PlayerMove.XMOVEMENT(1);
       
    }
    public void derechaOFF()
    {
        PlayerMove.XMOVEMENT(0);
        
    }

    //Acción izquierda
    public void izquierdaON()
    {
        PlayerMove.XMOVEMENT(-1);
    }
    public void izquierdaOFF()
    {
        PlayerMove.XMOVEMENT(0);
    }

    //Acción arriba
    public void arribaON()
    {
        PlayerMove.YMOVEMENT(1);
    }
    public void arribaOFF()
    {
        PlayerMove.YMOVEMENT(0);
    }

    //Acción abajo
    public void abajoON()
    {
        PlayerMove.YMOVEMENT(-1);
    }
    public void abajoOFF()
    {
        PlayerMove.YMOVEMENT(0);
    }

    public void AtacarOn()
    {
        clip.Play();

        float derechaX = 1;
        float izquierdaX = -1;
        float arribaY = 1;
        float abajoY = -1;
        if (derechaX == 1)
        {
            PlayerMove.atomizador(derechaX);

        }
        if (izquierdaX == -1)
        {
            PlayerMove.atomizador(izquierdaX);
        }
        if (arribaY == 1)
        {
            PlayerMove.atomizador(arribaY);
        }
        if (abajoY == -1)
        {
            PlayerMove.atomizador(abajoY);
        }
    }

        public void AtacarOff()
    {
        float derechaX = 0;
        float izquierdaX = 0;
        float arribaY = 0;
        float abajoY = 0;
        if (derechaX == 0)
        {
            
            PlayerMove.atomizador(derechaX);
        }
        if (izquierdaX == 0)
        {
           
            PlayerMove.atomizador(izquierdaX);
        }
        if (arribaY == 0)
        {
            
            PlayerMove.atomizador(arribaY);
        }
        if (abajoY == 0)
        {
            
            PlayerMove.atomizador(abajoY);
        }
    }

}
