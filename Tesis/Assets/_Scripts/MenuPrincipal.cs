using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject herramienta;
    public Transform lugarInicio;
    public float tiempoEspera = 2f;

    private bool herramientaEnLugar = false;

    void Update()
    {
        if (!herramientaEnLugar && herramienta.transform.position == lugarInicio.position)
        {
            herramientaEnLugar = true;
            Invoke("IniciarJuego", tiempoEspera);
        }
    }

    void IniciarJuego()
    {
        SceneManager.LoadScene("HojaNegra");
    }
}



