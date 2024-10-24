using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class BotonStart : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI CuentaAtras;
    [SerializeField]
    GameObject BotonInicio;
    [SerializeField]
    GameObject PantallaInicio;
    [SerializeField]
    GameObject PantallaFinal;
    [SerializeField]
    float tiempo = 60;
    private void Start()
    {
        
    }
    void Update()
    {
        InicioJuego();
        //Input.GetButtonDown("Space")
    }

    public void InicioJuego()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
         {
            PantallaInicio.SetActive(false);
            tiempo = tiempo - Time.deltaTime;
            if (tiempo <= 0)
            {
                PantallaFinal.SetActive(true);
            }
         }
        }
}
