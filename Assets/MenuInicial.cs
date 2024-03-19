using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel 1");

    }
    public void Instrucciones()
    {
        SceneManager.LoadScene("Instrucciones");

    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");

    }
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();

    }

}
