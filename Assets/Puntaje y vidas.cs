using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] int puntaje;
    [SerializeField] int Vidas;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI textvidas;
    
    private void Update()
    {
        puntos.text = "Puntos: " + puntaje.ToString();
        textvidas.text = "vidas: " + Vidas.ToString();
    }
    public void Sumarpuntos(int puntosmonedas)
    {
        puntaje += puntosmonedas;
    }
    public void Restarvida(int restarvidas)
    {
        Vidas += restarvidas;
    }
    public void Perder()
    {
        SceneManager.LoadScene("Derrota");
    }
    public void Ganar()
    {
        SceneManager.LoadScene("Victoria");
    }
}
