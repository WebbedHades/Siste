using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ColisionArbol : MonoBehaviour
{
    [SerializeField]
    float tiempo;
    float contador;
    bool arbolCortado = false;
    public UnityEvent tocar;

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    GameObject manager;
    MyManager myManager;

    void Start()
    {
        manager = GameObject.Find("MyManager");
        myManager = manager.GetComponent<MyManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
      
        if (other.gameObject.name == "Chainsaw" && !arbolCortado)
        {
            
            contador += Time.deltaTime;
            if (contador >= tiempo)
            {
                print("cae arbol");
                myManager.ArbolCortado();
                arbolCortado = true;
                Destroy(gameObject); // Destruye este GameObject (el árbol)
            }
        }
    }

}