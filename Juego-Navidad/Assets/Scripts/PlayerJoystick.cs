using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public float runSpeed=2;
    public float runSpeedHorizontal=2;
    public float runSpeedVertical = 2;
    public FixedJoystick fixedJoystick;
    Rigidbody2D rb2D;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    public void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate() 
    {
        horizontalMove = fixedJoystick.Horizontal * runSpeedHorizontal;
        verticalMove = fixedJoystick.Vertical * runSpeedVertical;
        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
    }

    private void Update()
    {
        if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetInteger("State", 4);
        }
        else if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetInteger("State", 3);
        }
        else
        {
            animator.SetInteger("State", 0);
        }

        if (verticalMove > 0)
        {
            animator.SetInteger("State",1);
        }
        else if (verticalMove < 0)
        {
            animator.SetInteger("State", 2);
        }
        else
        {
            animator.SetInteger("State", 0);
        }
    }
}