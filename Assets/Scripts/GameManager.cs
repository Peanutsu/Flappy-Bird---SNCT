using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [SerializeField] private GameObject _gameOver;
        private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
       
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    
}
