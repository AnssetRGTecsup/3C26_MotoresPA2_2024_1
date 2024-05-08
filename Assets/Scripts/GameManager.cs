using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject jugador1;
    public GameObject jugador2;
    
    
    private bool turnoJugador1 = true;

    
        void Start()
        {
            jugador1.tag = "Presa";
            jugador2.tag = "Cazador";
            
        }
    
        
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarRoles();
        }

        
    }

    void CambiarRoles()
    {
        if (turnoJugador1)
        {
            if (jugador1.CompareTag("Presa") && jugador2.CompareTag("Cazador"))
            {
                jugador1.tag = "Cazador";
                jugador2.tag = "Presa";
                turnoJugador1 = false;
            }
        }
        else
        {
            if (jugador1.CompareTag("Cazador") && jugador2.CompareTag("Presa"))
            {
                jugador1.tag = "Presa";
                jugador2.tag = "Cazador";
                turnoJugador1 = true;
            }
        }
    }
}