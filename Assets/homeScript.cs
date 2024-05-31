using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;

public class homeScript : MonoBehaviour
{
    public void Home()
    {
          MMSceneLoadingManager.LoadScene("PantallaInicio");

    }
}
