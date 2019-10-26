using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSpawn : MonoBehaviour
{

    public float maxTime = 3f;
    float curTime = 0f;


    public GameObject Spawn;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>().hasJumped || maxTime <= curTime)
        {
            gameObject.SetActive(false);
        }
        else
            curTime += Time.deltaTime;
    }

}
