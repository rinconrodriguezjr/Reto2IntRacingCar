using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a la que deseas cambiar

    public void ChangeScene()
    {
        // Cargar la escena especificada
        SceneManager.LoadScene(sceneToLoad);
    }
}
