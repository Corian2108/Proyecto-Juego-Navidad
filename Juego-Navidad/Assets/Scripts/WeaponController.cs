using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    public float municion = 100;
    public Image barraMunicion;

    void Update()
    {
        municion = Mathf.Clamp(municion, 0, 100);
        barraMunicion.fillAmount = municion / 100;
    }

    public void disparo(float cantidad){
        municion += cantidad;
    }
}
