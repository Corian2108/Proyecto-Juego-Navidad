using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveController : MonoBehaviour
{
    
    public float vidaPlayer;
    public Image barraVida;

    void Update()
    {
        vidaPlayer = Mathf.Clamp(vidaPlayer, 0, 100);
        barraVida.fillAmount = vidaPlayer/100;
    }
}
