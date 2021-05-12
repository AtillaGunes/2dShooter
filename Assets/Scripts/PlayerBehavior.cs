using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 move;
    public int health = 10;
    public Text healthDisplay;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        healthDisplay.text = "HEALTH :" + health;
     if(health <= 0){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     }
     Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
     move = moveInput.normalized * speed;
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}
