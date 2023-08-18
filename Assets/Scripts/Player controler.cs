using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    public static Playercontroler instance;


    [Header("Movimiento")]
    public float movespeed;

    [Header("Salto")]
    public float jumpForce;
    private bool canDoubleJump;
    public float bounceForce;

    [Header("Componentes")]
    public Rigidbody2D theRB;

    [Header("Grounded")]
    public Transform groundCheckpoint;
    public LayerMask whatIsGround;   
    private bool isGrounded;

    [Header("Animator")]
    public Animator anim;
    public SpriteRenderer theSR;
    

    public float knockBackLength, knockBackForce;
    private float knocBackCounter;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
       anim= GetComponent<Animator>(); 
       theSR= GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        

        if (knocBackCounter <= 0)
        {
            theRB.velocity = new Vector2(movespeed * Input.GetAxis("Horizontal"), theRB.velocity.y);

            isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, .2f, whatIsGround);

            if (isGrounded)
            { //complementa el doble salto
                canDoubleJump = true;
            }

            if (Input.GetButtonDown("Jump")) //regula el salto
            {
                if (isGrounded)
                {//el if evita el salto infinito
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce); //función de salto 
                }
                else
                {
                    if (canDoubleJump)
                    { //regula el doble salto
                        theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                        canDoubleJump = false;
                    }
                }

            }
            //hace que se voltee el script del player cuando se camina hacia atras
            if (theRB.velocity.x < 0)
            {
                theSR.flipX = true;
            }
            else if (theRB.velocity.x > 0)
            {
                theSR.flipX = false;
            }

        }
        else
        {
            knocBackCounter -= Time.deltaTime;
            if (!theSR.flipX)
            {
                theRB.velocity = new Vector2(-knockBackForce, theRB.velocity.y);
            }
            else
            {
                theRB.velocity = new Vector2(knockBackForce, theRB.velocity.y);
            }
        }


        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded", isGrounded);

    }

    public void Knockback()
    {
        knocBackCounter = knockBackLength;
        theRB.velocity = new Vector2(0f, knockBackForce);
    }

    public void Bounce()
    {
        theRB.velocity = new Vector2(theRB.velocity.x, bounceForce);
    }
}
