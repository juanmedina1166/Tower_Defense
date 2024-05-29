using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarTorres : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Torres; // Prefab de la torre que se va a colocar

    private void OnMouseDown()
    {
        if (Torres != null && !EstaOcupado())
        {
            // Coloca la torre en la posici�n del lugar de construcci�n
            Instantiate(Torres, transform.position, Quaternion.identity);
            MarkAsOcupado();
        }
    }

    private bool ocupado = false;

    // Verifica si el lugar de construcci�n ya est� ocupado
    public bool EstaOcupado()
    {
        return ocupado;
    }

    // Marca el lugar de construcci�n como ocupado
    public void MarkAsOcupado()
    {
        ocupado = true;
    }
}
