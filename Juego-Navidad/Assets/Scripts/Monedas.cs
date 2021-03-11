//Este script controla las monedas

using UnityEngine;

public class Monedas : MonoBehaviour
{
	public Inventario inventario;
	

	void Start()
	{
		inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
        {
			inventario.Cantidad= inventario.Cantidad + 2;
			inventario.puntos.text ="Monedas:"+ inventario.Cantidad.ToString();
			Destroy(gameObject);
		}
										//Destruimos el objeto
	}

}