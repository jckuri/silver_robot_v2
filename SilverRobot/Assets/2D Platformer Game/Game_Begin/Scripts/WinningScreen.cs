using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningScreen : MonoBehaviour {
    
    public void Setup() {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void RestartButton() {
        gameObject.SetActive(false);
        Game.instance.RestartGame();
    }

}