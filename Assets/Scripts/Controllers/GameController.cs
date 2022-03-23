using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    [SerializeField] private UIManager managerUI;
    private int point = 0;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        managerUI = FindObjectOfType<UIManager>();
    }

    public void GameOver()
    {
        managerUI.ActivateGameOver();
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        managerUI.DisableGameOver();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void IncrementPoint()
    {
        managerUI.SetPoint(++point);
    }


}