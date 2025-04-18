using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireMovement : MonoBehaviour {

    public const float fireSpeed = 20.0f;
    [NonSerialized] private float horizontalSpeed = -fireSpeed;
    [SerializeField] public Rigidbody2D rb;

    void Awake() {
        horizontalSpeed = -fireSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start() {     
        horizontalSpeed = -fireSpeed;
    }

    // Update is called once per frame
    void Update() {
        if(horizontalSpeed > 0) horizontalSpeed = fireSpeed; else horizontalSpeed = -fireSpeed;
        rb.velocity = new Vector2(horizontalSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D other) { 
        string tag = other.gameObject.tag;
        if(tag == "Player") {
            Game.instance.GameOver();
        }
        if(tag == "FireLimit") {
            horizontalSpeed *= -1;
        }
    }

}