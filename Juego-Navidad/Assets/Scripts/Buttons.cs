using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    
    public Buttons[] buttonArray;
    public float coldTime;

    public void ColdTimer()
    {
        while (coldTime > 0)
        {
            /*runButton.interactable = false; */
        }
    }

    void Attack()
    {

    }
}
