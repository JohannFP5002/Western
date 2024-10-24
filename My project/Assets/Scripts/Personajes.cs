using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes : MonoBehaviour
{
   
    [SerializeField]
    GameObject Personas;
    [SerializeField]
    GameObject Posiciones;
    [SerializeField]
    float precioBadGuy;
    [SerializeField]
    float precioBadGuy2;
    [SerializeField]
    float precioGoodGuy;
    [SerializeField]
    float precioLady;
    [SerializeField]
    float precioSherif;
    int i;
    public GameObject[] PersonajesAleatorios;
    int p;
    public GameObject[] PosicionPersonajes;
    float time = 0;

    void Start()
    {
        Personas.SetActive(false);
        precioBadGuy = 500f;
        precioBadGuy2 = 750f;
        precioGoodGuy = -50f;
        precioLady = -80f;
        precioSherif = -100f;
    }

    // Update is called once per frame
    void Update()
    {
        Personas = PersonajesAleatorios[Random.Range (0, PersonajesAleatorios.Length)];
        Posiciones = PosicionPersonajes[Random.Range(0, PosicionPersonajes.Length)];
    }
    public void RespawnDeObjetivos()
    {
        time = time + Time.deltaTime;
        if (time >= 5)
        {

            time = 0;
            
        }
    }
    public void Disparar()
    {

    }
}
