using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public MiniGame miniGame;
    private ButtonPrefab miniGameButton;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        miniGameButton = collision.GetComponent<ButtonPrefab>();
       if(!miniGameButton.scored){
            //restar puntos
            miniGame.noScore(); 
       }
    }
}
