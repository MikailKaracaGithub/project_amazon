using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public float width;

    private int toSpawn;
    public GameObject[] platforms;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer > maxTime)
        {
            toSpawn = Random.Range(0, platforms.Length);

            GameObject newPlatform = Instantiate(platforms[toSpawn]);
            newPlatform.transform.position = transform.position + new Vector3(Random.Range(width, -width),0, 0);
            Destroy(newPlatform, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
