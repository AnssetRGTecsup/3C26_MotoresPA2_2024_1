using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] int velocidad;

    [SerializeField] int Puntaje;
    Transform _transform;
    PlayerInput _plainput;
    Rigidbody reig;
    private Vector2 moveInput;
    public TMP_Text puntajeTexto;
    public GameObject objetoParaVolverAVer;
    public Transform PocisionReinicio;

    private void Awake()
    {
        _transform = transform;
        _plainput = GetComponent<PlayerInput>();
        reig = GetComponent<Rigidbody>();
        objetoParaVolverAVer.SetActive(false);
    }

    private void Update()
    {
        Vector3 moveDirection = new Vector3(moveInput.x, moveInput.y, 0f);
        transform.Translate(moveDirection * velocidad * Time.deltaTime);
        if (Puntaje >= 4)
        {
            objetoParaVolverAVer.SetActive(true);

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Cazador") && other.CompareTag("Presa"))
        {
            Puntaje++;
            ActualizarTextoPuntaje();
            
        }
        if (other.gameObject)
        {
           
            _transform.position = PocisionReinicio.position;
        }





    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void ActualizarTextoPuntaje()
    {
        puntajeTexto.text = "Puntaje: " + Puntaje;
    }
    private void OnEnable()
    {

        RhythmSystem.OnBeat += CompasReached;
        RhythmSystem.OnBeatstop += STO;
    }

    private void OnDisable()
    {

        RhythmSystem.OnBeat -= CompasReached;
        RhythmSystem.OnBeatstop -= STO;
    }
    private void CompasReached()
    {
        velocidad = 5;
    }
    private void STO()
    {
        velocidad = 0;
    }
}
