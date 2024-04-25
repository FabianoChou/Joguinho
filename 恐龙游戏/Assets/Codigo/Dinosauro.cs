using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donosauro : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
    bool isJumping;
    public GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    
    public Animator animatorComponent;


    void Update()
    {
        

        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector2(0, jump);
            isJumping = true;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Abaixar();
        }
        
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            levantar();
}

    }
    void Abaixar()
    {
        animatorComponent.SetBool("Abaixado",true);
    }
    void levantar()
    {
        animatorComponent.SetBool("Abaixado", false );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;

        if (collision.gameObject.tag== "Cactus")
        {
            gm.GameOver();
        }

    }
}

