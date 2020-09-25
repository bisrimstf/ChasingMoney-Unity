﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldmanscript : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;

    PlayerMovement target;
    Vector2 moveDirection;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            GameControlScript.health -= 1;
            SoundManagerScript.PlaySound("hitsound");
            Destroy(gameObject);
        }  

    }
}
