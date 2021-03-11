//Este script controla la Interfaz de Usuario

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
	//Esta clase tiene una referencia static a sí misma para asegurar que sólo habrá una.
	//A esto se le llama: patrón "singleton"
	//Al ser static podemos acceder desde otros scripts con UIManager.current
	//Otros scripts acceden a éste a través de sus métodos public static
	static UIManager current;

	public TextMeshProUGUI monedasText;     //Texto que muestra el número de monedas
	public TextMeshProUGUI tiempoText;      //Texto que muestra el tiempo

	public Image healthBar;

	void Awake()
	{
		//Si existe un UIManager y no es este...
		if (current != null && current != this)
		{
			//...destruimos y salimos
			Destroy(gameObject);
			return;
		}

		//Si no tenía valor el UIManager se lo ponemos
		//Objeto persistente (no le afecta el cambio de escenas)
		current = this;
		DontDestroyOnLoad(gameObject);
	}

	void Start()
	{
		current.healthBar.fillAmount = 1f;
	}

	public static void ActualizarMonedasUI(int monedasCount)
	{
		//Si no existe el UIManager, salimos
		if (current == null)
			return;

		//Actualizamos el texto de las monedas
		current.monedasText.text = monedasCount.ToString();
	}

	public static void UpdateTimeUI(float time)
	{
		//Si no existe el UIManager, salimos
		if (current == null)
			return;

		//Convertimos el tiempo a minutos y segundos
		int minutes = (int)(time / 60);
		float seconds = time % 60f;

		//Actualizamos el texto del tiempo
		current.tiempoText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}

	public static void ActualizarVidaUI(int vidaCount)
	{
		//Si no existe el UIManager, salimos
		if (current == null)
			return;

		//Actualizo la barra de vida
		current.healthBar.fillAmount = (float)vidaCount / 100f;
	}
}
