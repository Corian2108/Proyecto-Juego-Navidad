using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    
    public float completado = 0;
    public Image barraNivel;

    void Update()
    {
        completado = Mathf.Clamp(completado, 0, 100);
        barraNivel.fillAmount = completado/100;
    }
}
