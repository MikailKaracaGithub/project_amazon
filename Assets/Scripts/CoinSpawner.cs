using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public float width;

    private int toSpawn;
    public GameObject[]Coin;

    void Update()
    {
        if (timer > maxTime)
        {
            toSpawn = Random.Range(0, Coin.Length);

            GameObject newCoins = Instantiate(Coin[toSpawn]);
            newCoins.transform.position = transform.position + new Vector3(Random.Range(width, -width), 0, 0);
            Destroy(newCoins, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
