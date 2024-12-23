﻿using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton لتسهيل الوصول
    private int score = 0;               // النقاط الحالية
    [SerializeField] private TMP_Text _scoreText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        AddScore(500);
    }

    public void AddScore(int points)
    {
        score += points;
        _scoreText.text = $"Score: {score}";
        Debug.Log("Score: " + score); // استبدل بـ UI Update لاحقًا
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int GetScore()
    {
        return score;
    }
}
