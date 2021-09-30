using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    public GameObject Front;
    public GameObject Back;
    public GameObject Left;
    public GameObject Right;
    public RuntimeAnimatorController[] Controller;
    Vector2 movement;

    public Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x > 0)
        {
            Anim.runtimeAnimatorController = Controller[3];
            Left.SetActive(false);
            Right.SetActive(true);
            Back.SetActive(false);
            Front.SetActive(false);
            Anim.SetBool("IDLE", false);
        }
        if (movement.x < 0)
        {
            Anim.runtimeAnimatorController = Controller[2];
            Left.SetActive(true);
            Right.SetActive(false);
            Back.SetActive(false);
            Front.SetActive(false);
            Anim.SetBool("IDLE", false);
        }

        if (movement.y > 0)
        {
            Anim.runtimeAnimatorController = Controller[1];
            Back.SetActive(true);
            Front.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
            Anim.SetBool("IDLE", false); 
            
        }
        if (movement.y < 0)
        {
            Anim.runtimeAnimatorController = Controller[0];
            Back.SetActive(false);
            Front.SetActive(true);
            Left.SetActive(false);
            Right.SetActive(false);
            Anim.SetBool("IDLE", false);
            

        }
        if((movement.y == 0) && (movement.x == 0))
        {
            Anim.SetBool("IDLE", true);
        }

    }
    private void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
