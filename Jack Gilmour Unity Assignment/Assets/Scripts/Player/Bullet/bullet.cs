﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f; //Sets the speed of the bullet
    public Rigidbody2D rb;



    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) //Destroys the Bullet when hit with another collider
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

   
}