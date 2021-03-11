using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuGame : MonoBehaviour
{
    public void EscenaJuego(string escenaInicio)
    {
        //Nombre del juego al iniciar
        SceneManager.LoadScene(escenaInicio);
    }
    public void EscenaInstrucciones(string escenaInstrucciones)
    {
        //Nombre del juego al iniciar
        SceneManager.LoadScene(escenaInstrucciones);
    }
    public void EscenaOpcion()
    {
        SceneManager.LoadScene("Options");
    }
    public void EscenaSalir()
    {
        Application.Quit();
        Debug.Log("Juego cerrado");
    }
}
