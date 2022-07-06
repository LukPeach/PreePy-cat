using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 5f;

    public static bool checkCoin = false;

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            Gamemanger.coingame++;
            checkCoin = true;
            Destroy(gameObject);
        }
        if (collision.tag == "Wallend")
        {
            checkCoin = true;
            Destroy(gameObject);
        }
    }
}
