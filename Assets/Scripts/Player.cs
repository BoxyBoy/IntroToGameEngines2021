﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public float jumpSpeed = 50.0f;

    void Update()
    {

        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) velocity.y = jumpSpeed;

        transform.position += velocity * speed * Time.deltaTime;
    }
}
