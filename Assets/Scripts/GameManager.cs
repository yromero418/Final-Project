using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    [SerializeField] private Text scoreText;

    private int coinCount;

    private void Awake() {
        Instance = this;
        UpdateScoreUI();
    }

    public void AddCoin() {
        coinCount++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI() {
        scoreText.text = "Coins: " + coinCount;
    }
}
