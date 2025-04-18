using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] public int coinCount = 0;
    [SerializeField] public int totalCoins = 18;
    public Text coinText;

    // Start is called before the first frame update
    void Start() {
        coinCount = 0;
        Game.instance.coinManager = this;
    }

    // Update is called once per frame
    void Update() {
        coinText.text = "Coins: " + coinCount.ToString() + " / " + totalCoins.ToString();
    }
}
