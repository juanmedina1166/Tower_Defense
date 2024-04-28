using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class FindeJuego : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.CurrentLives <= 0) 
        {
            SceneManager.LoadScene("Game Over");
        }
        
    }
}
