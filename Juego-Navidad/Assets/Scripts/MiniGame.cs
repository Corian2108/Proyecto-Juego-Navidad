using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniGame : MonoBehaviour
{
    //barra de nivel
    public float filled = 5;
    public float puntuacion = 5;
    public Image filledBar;
    public GameObject gameOverText;
    public GameObject youWinText;
    public bool gameOver = false;
    public bool winGame = false;

    void Update()
    {
        filled = Mathf.Clamp(filled, 0, 100);
        filledBar.fillAmount = filled/100;
        if(filled <= 0)
        {
            //Game over
            gameOver = true;
            gameOverText.SetActive(true);
            //Click para reiniciar
            if(gameOver && Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Minijuego");
            }

        }else if(filled == 100)
        {
            //You Win
            winGame = true;
            youWinText.SetActive(true);
            //Click para regresar al mundo
            if(winGame && Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Juego");
            }
        }
    }

    public void score()
    {
        filled = filled + puntuacion;
    }

    public void noScore()
    {
        filled = filled - puntuacion;
    }
}