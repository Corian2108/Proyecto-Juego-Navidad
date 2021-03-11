using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZone : MonoBehaviour
{
    public Sprite myObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<ButtonPrefab>().clickable = true;
       
    }
    private void OnTriggerExist2D(Collider2D collision)
    {

        if(collision.GetComponent<ButtonPrefab>().clickable == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = myObject;
        }
       
    }
}
