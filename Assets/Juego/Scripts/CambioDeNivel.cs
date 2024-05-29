using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeNivel : MonoBehaviour
{
    public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));
    }

    // Update is called once per frame
    void Update()
    {
        ChequearEnemigos();
    }

    void ChequearEnemigos()
    {
        // Elimina de la lista los enemigos que hayan sido destruidos
        enemies.RemoveAll(enemy => enemy == null);

        // Si la lista está vacía, todos los enemigos han sido eliminados
        if (enemies.Count == 0)
        {
            // Cambia a la siguiente escena
            CambioNivel();
        }
    }

    public void CambioNivel()
    {
        int nivelActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nivelActual + 1);
    }
}
