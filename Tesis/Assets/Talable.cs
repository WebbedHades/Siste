
using UnityEngine;

public class Talable : MonoBehaviour, ITalable
{
    [SerializeField] private int vidaInicial = 10;
    public int vida { get; set; }

    private void Start()
    {
        vida = vidaInicial;
    }

    public void ReducirVida(int vida)
    {
        this.vida -= vida;
    }
}
