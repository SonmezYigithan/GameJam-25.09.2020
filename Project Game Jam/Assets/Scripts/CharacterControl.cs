using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public float sizeofCharacter;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Yürüme
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * MovementSpeed; 

        //zıplama
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        //Karakteri Döndürme
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -sizeofCharacter;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = sizeofCharacter;
        }
        transform.localScale = characterScale;
    }
}