using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject platforms;
    public float width;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPlatform = Instantiate(platforms);
            newPlatform.transform.position = transform.position + new Vector3(Random.Range(width, -width),0, 0);
            Destroy(newPlatform, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
