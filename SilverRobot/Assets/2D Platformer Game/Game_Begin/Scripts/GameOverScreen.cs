using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour {
    
    public Text coinsText;

    public void Setup(int coins) {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void RestartButton() {
        gameObject.SetActive(false);
        Game.instance.RestartGame();        
    }

}