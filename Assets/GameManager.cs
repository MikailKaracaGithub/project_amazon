using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool death = false;
    public float respawnTime = 1f;
    public void EndGame()
    {
        if (death == false)
        {
            death = true;
            Debug.Log("Game Over");
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   

}