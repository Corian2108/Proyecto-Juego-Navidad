using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Script 
    private Rigidbody2D TheBody = null;
    private Transform TheTransform = null;
    public float MaxSpeed = 4.0f;
    private float Vdirection = 0.0f;
    //private float Hdirection = 0.0f;
    private float Xmovement = 0.0f;
    private float Ymovement = 0.0f;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public float x1 = 0.0f;
    public float y1 = 0.0f;

    void Awake()
    {
        TheBody = GetComponent<Rigidbody2D>();
        TheTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Start()
    {

    }

    void FixedUpdate()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        Vector3 Direction = new Vector3(Xmovement, Ymovement, 0);

        TheBody.AddForce(Direction.normalized * MaxSpeed);


        if (Direction.y != 0 || Direction.x != 0)
        {
            TheBody.AddForce(Direction.normalized * MaxSpeed);
        }
        else
        {
            TheBody.velocity = new Vector3(0, 0, 0);
        }


        TheBody.velocity = new Vector2(
            Mathf.Clamp(TheBody.velocity.x, -MaxSpeed, MaxSpeed),
            Mathf.Clamp(TheBody.velocity.y, -MaxSpeed, MaxSpeed)
            );

    }

    public void Vertical(float Direction)
    {
        Vdirection = Direction;
        Debug.Log(Vdirection);
    }

    public void XMOVEMENT(float x)
    {
        Xmovement = x;
        if (Xmovement == 1)
        {

            animator.SetBool("WalkingRight", true);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
        else if (Xmovement == -1)
        {
            animator.SetBool("WalkingLeft", true);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
        else if (Xmovement == 0)
        {

            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
    }

    public void YMOVEMENT(float y)
    {
        Ymovement = y;

        if (Ymovement == 1)
        {
            animator.SetBool("WalkingBack", true);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingRight", false);
        }
        else if (Ymovement == -1)
        {
            animator.SetBool("WalkingFront", true);
            animator.SetBool("WalkingBack", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingRight", false);
        }
        else if (Ymovement == 0)
        {
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
    }

    public void atomizador(float x)
    {
        x1 = x;
        y1 = x;
        if (Xmovement==1 && x1==1)
        {
            animator.SetBool("AttackFront", false);
            animator.SetBool("AttackBack", false);
            animator.SetBool("AttackLeft", false);
            animator.SetBool("AttackRight", true);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
        if (Xmovement== -1 && x1== -1)
        {
            animator.SetBool("AttackFront", false);
            animator.SetBool("AttackBack", false);
            animator.SetBool("AttackLeft", true);
            animator.SetBool("AttackRight", false);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }

        if(Ymovement==1 && y1 == 1)
        {
            animator.SetBool("AttackFront", false);
            animator.SetBool("AttackBack", true);
            animator.SetBool("AttackLeft", false);
            animator.SetBool("AttackRight", false);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
        if (Ymovement == -1 && y1 == -1)
        {
            animator.SetBool("AttackFront", true);
            animator.SetBool("AttackBack", false);
            animator.SetBool("AttackLeft", false);
            animator.SetBool("AttackRight", false);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }

        if (Xmovement == 0 && x1 == 0)
        {
            animator.SetBool("AttackFront", false);
            animator.SetBool("AttackBack", false);
            animator.SetBool("AttackLeft", false);
            animator.SetBool("AttackRight", false);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }
        if (Ymovement == 0 && y1 == 0)
        {
            animator.SetBool("AttackFront", false);
            animator.SetBool("AttackBack", false);
            animator.SetBool("AttackLeft", false);
            animator.SetBool("AttackRight", false);
            animator.SetBool("WalkingRight", false);
            animator.SetBool("WalkingLeft", false);
            animator.SetBool("WalkingFront", false);
            animator.SetBool("WalkingBack", false);
        }

    }
    private void Update()
    {

    }

}







