using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;
    }
    
    private void FixedUpdate()
    {
        MovePlayer();
        rigidBody.velocity = new Vector2(horizontalMove, rigidBody.velocity.y);
    }

    public void ButtonLeftDown()
    {
        moveLeft = true;
    }
    
    public void ButtonLeftUp()
    {
        moveLeft = false;
    }
    
    public void ButtonRightDown()
    {
        moveRight = true;
    }
    
    public void ButtonRightUp()
    {
        moveRight = false;
    }

    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -moveSpeed;
        }else if (moveRight)
        {
            horizontalMove = moveSpeed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

}
