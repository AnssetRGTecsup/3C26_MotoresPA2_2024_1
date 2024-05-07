using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class EnemyExample : MonoBehaviour
{
    [SerializeField] int velocidad = 5;
    [SerializeField] bool Gano;
    [SerializeField] int Puntaje;
    Transform _transform;
    PlayerInput _plainput;
    Rigidbody reig;
    private Vector2 moveInput;



    private void Awake()
    {
        _transform = transform;
        _plainput = GetComponent<PlayerInput>();
        reig = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        transform.Translate(moveDirection * velocidad * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Presa")) {

            Puntaje++;

            SceneManager.LoadScene("");
          
        }

    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

}





   

  
  



  

