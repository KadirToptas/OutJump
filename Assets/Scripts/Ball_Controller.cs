
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpPower;
    [SerializeField] private bool _isHit;
    void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime, 0f, 0f);

        if(Input.GetMouseButtonDown(0) && rb.velocity.y == 0) {
            rb.velocity = Vector2.up * _jumpPower;
            game_Manager._isStart = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("ShortEdge")) {
            _moveSpeed *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Star")) {
            game_Manager._starCount++;
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Flag")) {
            game_Manager.LevelUpdatePanel();
            game_Manager._isEnd = true;
        }

        if(other.gameObject.CompareTag("Ground")) {
            game_Manager.GameOver();
        }
    }
}

