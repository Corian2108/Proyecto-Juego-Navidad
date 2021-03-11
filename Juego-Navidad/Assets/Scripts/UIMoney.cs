using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMoney : MonoBehaviour
{
    public Text score;
    public int Cantidad = 5;

    void update() 
    {
        score.text = Cantidad.ToString();
    
    }
}
