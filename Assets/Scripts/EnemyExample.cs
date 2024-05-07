using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class EnemyExample : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] bool Gano;
    [SerializeField] int Puntaje;
   
     Vector2  _movementInput;







    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Presa")) {

            Puntaje++;

            SceneManager.LoadScene("");
          
        }


    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _movementInput = context.ReadValue<Vector2>();
    }
}