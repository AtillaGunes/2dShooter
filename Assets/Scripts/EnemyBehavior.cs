using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed;
    private PlayerBehavior player;
    private Transform playerPos;
    public GameObject particle;
    void Start()
    {
       playerPos = GameObject.FindGameObjectWithTag("Player").transform;
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            Instantiate(particle, transform.position, Quaternion.identity);
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
        }
        if(other.CompareTag("Bullet")){
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
