using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject coin;
    private int randomSpawn;

    private void Update()
    {
       if(Coin.checkCoin)
        {
            Spawncoin();
        }
    }
    void Spawncoin()
    {
        randomSpawn = Random.Range(0, 3);
        GameObject coine = Instantiate(coin, spawnPoint[randomSpawn].position, Quaternion.identity);
        Coin.checkCoin = false;
    }
}
