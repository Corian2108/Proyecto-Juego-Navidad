﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        collision.GetComponent<ButtonPrefab>().clickable = true;
    }
}
