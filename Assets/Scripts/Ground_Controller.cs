using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Controller : MonoBehaviour
{
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        if(game_Manager._isStart == true && game_Manager._isDead == false && game_Manager._isEnd == false) {
            transform.Translate(0f, _moveSpeed * Time.deltaTime, 0f);
        }
    }
}