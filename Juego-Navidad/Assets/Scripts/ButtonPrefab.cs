using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ButtonPrefab : MonoBehaviour
{
    public float scrollSpeed = -2.5f;
    private Rigidbody2D rb2d;
    private Vector3 clicked;
    public bool clickable;
    public float clickRadius = 1;
    private Vector3 target;
    private MiniGame miniGame;
    private ButtonsPool spawnQuantity;
    public bool scored;
    private Renderer render;
    public AudioSource clip;
    
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        clickable = false;
        scored = false;
        rb2d.velocity = new Vector2(0, scrollSpeed);
        miniGame = GameObject.FindWithTag("GameController").GetComponent<MiniGame>();
        spawnQuantity = GameObject.FindWithTag("GameController").GetComponent<ButtonsPool>();
        render = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(0, scrollSpeed);
        if(miniGame.gameOver | miniGame.winGame)
        {
            scrollSpeed = 0;
            rb2d.velocity = new Vector2(0, scrollSpeed);
        }
        if (clickable)
        {
            
            //capturar posicion del botón
            target = transform.position;
            target.z = 0f;
            
            //capturar posicion del click
            if (Input.GetMouseButtonDown(0))
            {
                clip.Play();
                clicked = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                clicked.z = 0f;
                //Calcular diferencia
                float distance = Vector3.Distance(clicked, target);
                if (distance < clickRadius)
                {
                    //desaparecer objeto
                    render.enabled = false;
                    //sumar punto
                    scored = true;
                    miniGame.score();
                    scrollSpeed -= 1f;
                    if(spawnQuantity.spawnRate > spawnQuantity.minimumSpawn)
                    {
                        spawnQuantity.spawnRate -= 0.1f;
                    }
                }

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, clickRadius);
    }
}
