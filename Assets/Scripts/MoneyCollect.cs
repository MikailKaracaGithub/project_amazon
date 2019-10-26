using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollect : MonoBehaviour
{
    public int moneyAmount = 0;
    private GameObject dollar;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log(other.gameObject.name + "has entered the collider");
            moneyAmount++;
            GameObject.Destroy(gameObject);
        }  
        
        
    }
}
