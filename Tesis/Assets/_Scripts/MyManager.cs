using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class MyManager : MonoBehaviour
{
   
    public UnityEvent terminoArboles;
    int animalesMuertos = 0;
    int dia = 1;
    int arbolesCortados = 0;
    [SerializeField] int cantidadArboles;
    [SerializeField] float tiempoTranscurrido;
    [SerializeField]
    List<GameObject> zonaCorte = new List<GameObject>();
    void Awake()
    {
        print(Variables.dia);

        /*if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            Debug.Log("Más de un GameManager en escena");
            Destroy(this);
         }*/
        /*if(Instance != null && Instance != this){
            Destroy(this.gameObject);
            print("destruyendo");
            return;

        }
        Instance = this;*/
        //DontDestroyOnLoad(this);

        print("Estoy en dia " + Variables.dia);
        switch (Variables.dia)
        {
            case 0:
                zonaCorte[0].SetActive(true);
                break;
            case 1:

                zonaCorte[0].SetActive(false);
                zonaCorte[1].SetActive(true);
                break;

            case 2:

                zonaCorte[0].SetActive(false);
                zonaCorte[1].SetActive(false);
                zonaCorte[2].SetActive(true);

                break;
        }

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            //vamos al segundo dia
            Variables.dia++;
            SceneManager.LoadScene("Juego");
            
        }
    }
    public void MatarAnimal()
    {
        animalesMuertos++;  
        print("Voy matando:  " + animalesMuertos);
        if (animalesMuertos == 3)
        {
            print("mate a todos");
        }

    }
    public void ArbolCortado()
    {
        arbolesCortados++;
        if (arbolesCortados >= cantidadArboles)
        {
            terminoArboles.Invoke();
            print("Se cortaron los arboles");
            Invoke("TerminarDia", tiempoTranscurrido);
        }

    }
    void TerminarDia()
    {
        print("paso el tiempo");
       // Variables.dia++;
        SceneManager.LoadScene("Juego");//si es dia 1 va a escena cazar
    }
}
