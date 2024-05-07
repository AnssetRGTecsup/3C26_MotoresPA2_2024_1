using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechasGenerador : MonoBehaviour
{
    public GameObject flechaPrefab;
    public Transform puntoGeneracion; 
    public float velocidad = 5f; 
    public float intervalo = 2f;
    public float direction = 0f;
    private float tiempoTranscurrido = 0f;

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= intervalo)
        {
            GenerarFlecha();
            tiempoTranscurrido = 0f;
        }
    }

    void GenerarFlecha()
    {
        GameObject flecha = Instantiate(flechaPrefab, puntoGeneracion.position, puntoGeneracion.rotation);
        Rigidbody2D rb = flecha.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = puntoGeneracion.forward * velocidad;
            flecha.GetComponent<Rigidbody2D>().velocity = new Vector2(direction * velocidad, 0);
        }
        else
        {
            Debug.LogError("El prefab de la flecha debe tener un componente Rigidbody para funcionar correctamente.");
        }
    }
}
