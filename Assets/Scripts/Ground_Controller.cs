using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Controller : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Game_Manager gm;
    void Update()
    {
        if (gm.isStarted == true)
        {
        transform.Translate(0f,_moveSpeed*Time.deltaTime,0f);
        }
    }
    
    
}
