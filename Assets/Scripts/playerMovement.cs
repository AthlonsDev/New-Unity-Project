using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    public GameObject shadow;

    bool jump = false;

    bool canDoubleJump = false;

    bool grounded = true;

    public Rigidbody2D rb;

    private float m_JumpForce = 200f;

    //  bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("LeftH") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                jump = true;
                canDoubleJump = true;
                Debug.Log("Jumping");
                animator.SetBool("isJumping", true);
                grounded = false;
            } else
            {
                doubleJump();
            }
            

        }


        

        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //}
       //else if (Input.GetButtonUp("Crouch"))
        //{
        //    Debug.Log("get up!");
        //    crouch = false;
        //}

        
        
    }

    void doubleJump()
    {
            if (canDoubleJump == true)
            {
                canDoubleJump = false;
                Debug.Log("Double Jumping");
            // animator.SetBool("isJumping", false);
            rb.AddForce(new Vector2(0f, m_JumpForce));
            animator.SetBool("isDoubleJump", true);
            }

    }

    public void onLanding()
    {
        Debug.Log("Landed");
        grounded = true;
        animator.SetBool("isJumping", false);
        animator.SetBool("isDoubleJump", false);
    }

    public void onCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
