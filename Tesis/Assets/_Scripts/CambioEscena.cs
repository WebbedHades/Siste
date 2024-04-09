using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Nombre de la escena que deseas cargar al hacer clic en el bot�n
    public string HojaNegra;

    // M�todo que se llama cuando se hace clic en el bot�n
    public void LoadScene()
    {
        SceneManager.LoadScene(HojaNegra); // Cargar la escena especificada
    }

    public void Exit()
    {
        Application.Quit();
    }
}
