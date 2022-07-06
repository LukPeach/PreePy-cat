using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;  //Position that use to destroy pipes

    public static bool checkPole = false;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;  //Set leftEdge = left edge of camera
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;  //Auto move pipes to left side 

        if (transform.position.x < leftEdge)  //Destroy pipes if touch left edge of camera
        {
            checkPole = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Gamemanger.scoregame++;
        }
    }
}

