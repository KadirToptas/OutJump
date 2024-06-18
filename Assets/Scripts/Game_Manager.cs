
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public bool isStarted;
    public int starCount;
    private int _currentLevelIndex;
    void Start()
    {
        isStarted = false;
        _currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelUpdate()
    {
        SceneManager.LoadScene(_currentLevelIndex +1);
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene(_currentLevelIndex);
    }
}
