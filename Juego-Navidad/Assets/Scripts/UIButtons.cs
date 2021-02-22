using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    
    public UIButtons[] buttonArray;
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
