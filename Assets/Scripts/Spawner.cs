using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnSpots;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

  
    void Update()
    {
        if(timeBtwSpawn <= 0){
            int RandonPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(enemy, spawnSpots[RandonPos].position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
