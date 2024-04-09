using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    
    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
