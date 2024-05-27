using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class FindeJuego : MonoBehaviour
{
    private bool gameOver = false;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.CurrentLives <= 0 && !gameOver) 
        {
            gameOver = true;
            MMSceneLoadingManager.LoadScene("Game Over");
        }
        
    }

}
