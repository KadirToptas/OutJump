using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpPower;

    [SerializeField] private Game_Manager gm;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(_moveSpeed*Time.deltaTime,0f,0f);
        if (Input.GetMouseButtonDown(0)&& rb.velocity.y ==0)
        {
            rb.velocity = Vector2.up * _jumpPower;
            gm.isStarted = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ShortEdge"))
        {
            _moveSpeed *= -1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            gm.starCount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Flag"))
        {
            gm.LevelUpdate();
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            gm.GameOver();
        }
    }
}
