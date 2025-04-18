using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game instance;

    public void Awake() {
        if(instance == null) instance = this;
        Time.timeScale = 2;

        coinAudioSource = gameObject.AddComponent<AudioSource>();
        deathAudioSource = gameObject.AddComponent<AudioSource>();
        jumpAudioSource = gameObject.AddComponent<AudioSource>();
        landingAudioSource = gameObject.AddComponent<AudioSource>();
        winningAudioSource = gameObject.AddComponent<AudioSource>();
    }

    public CoinManager coinManager;
    public GameOverScreen gameOverScreen;
    public WinningScreen winningScreen;
    public SpriteRenderer woodsBackground;
    public SpriteRenderer cloudsBackground;
    public AudioSource coinAudioSource, deathAudioSource, jumpAudioSource, landingAudioSource, winningAudioSource;
    public AudioClip coinSound, deathSound, jumpSound, landingSound, winningSound;
    public PlayerMovement player;

    // public void playSound(AudioClip clip) {
    //     audioSource.clip = clip;
    //     audioSource.Play();
    // }

    public void playCoin() {
        coinAudioSource.clip = coinSound;
        coinAudioSource.Play();
    }

    public void playDeath() {
        deathAudioSource.clip = deathSound;
        deathAudioSource.Play();
    }

    public void playJump() {
        jumpAudioSource.clip = jumpSound;
        jumpAudioSource.Play();
    }

    public void playLanding() {
        landingAudioSource.clip = landingSound;
        landingAudioSource.Play();
    }

    public void playWinning() {
        winningAudioSource.clip = winningSound;
        winningAudioSource.Play();
    }

    public void GameOver() {
        player.setDeath(true);
        Game.instance.playDeath();
        gameOverScreen.Setup(coinManager.coinCount);        
    }

    public void Win() {
        Game.instance.playWinning();
        winningScreen.Setup();        
    }

    public void RestartGame() {
        SceneManager.LoadScene("Game_Begin");        
        Time.timeScale = 2;
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
