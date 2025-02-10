using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// jackson Bell
public class Movement : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpforce = 20f;
    [SerializeField] private bool IsJumping = false;

    private Rigidbody2D rb;
    //start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

//update is called once per frame
    void Update()
    {
    //code for horizontal movement
    float horizontalInput = Input.GetAxis("Horizontal");
    Vector2 moveVector = new Vector2 (horizontalInput * movespeed, rb.velocity.y);
    //player is jumping
    if (Input.GetButtonDown("Jump") && !IsJumping){
        moveVector.y = jumpforce;
        IsJumping = true;
    }
    rb.velocity = moveVector;

    if (horizontalInput < 0){
        transform.localScale = new Vector3(-4, 3, 1);
    } else if (horizontalInput > 0){
        transform.localScale = new Vector3(4, 3, 1);
    }
    
    }

    private void OnCollisionEnter2D(Collision2D collison){
    if(collison.gameObject.CompareTag("Ground")){
        IsJumping = false;
    }
    }
}