using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPole : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject pole;
    private int randomSpawn;

    private void Update()
    {
        if (Pole.checkPole)
        {
            Spawnpole();
        }
    }
    void Spawnpole()
    {
        randomSpawn = Random.Range(0, 3);
        GameObject polet = Instantiate(pole, spawnPoint[randomSpawn].position, Quaternion.identity);
        Pole.checkPole = false;
    }
}
