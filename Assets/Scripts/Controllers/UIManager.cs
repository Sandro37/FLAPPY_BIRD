using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject gameOver;
    [SerializeField] private Text point;

    public void SetPoint(int point)
    {
        this.point.text = point.ToString();
    }
    public void ActivateGameOver() => gameOver.SetActive(true);
    public void DisableGameOver() => gameOver.SetActive(false);
    
}
