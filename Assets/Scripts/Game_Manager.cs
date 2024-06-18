
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public GameObject _levelUpdatePanel;
    public Image[] _stars;
    public bool _isStart;
    public bool _isDead;
    public bool _isEnd;
    public int _starCount = 0;
    public int _currentLevel;
    void Start()
    {
        _isStart = false;
        _isDead = false;
        _isEnd = false;
        _currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        
    }

    public void GameOver() {
        SceneManager.LoadScene(_currentLevel);
    }

    public void LevelUpdatePanel() {
        _levelUpdatePanel.SetActive(true);

        for(int i = 0; i < _starCount; i++) {
            _stars[i].enabled = true;
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(_currentLevel);
    }
    
    public void LevelUpdate() {
        SceneManager.LoadScene(_currentLevel + 1);
    }
}

