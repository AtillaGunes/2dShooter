using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    private Transform playerPos;
    void Start()
    {
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Instantiate(bullet, playerPos.position, Quaternion.identity);
        }

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Instantiate(bullet, playerPos.position, Quaternion.identity);
            }
        }
    }
}
