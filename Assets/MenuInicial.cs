using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;



public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1");

    }
    public void Instrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");

    }
    public void Creditos()
    {
        MMSceneLoadingManager.LoadScene("Creditos");

    }
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();

    }

}
