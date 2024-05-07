using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    public static int puntaje;
    public static int Vidas = 4;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI textvidas;

    private void Update()
    {
        puntos.text = "Puntos: " + puntaje.ToString();
        textvidas.text = "vidas: " + Vidas.ToString();
        if (Vidas <= 0)
        {
            SceneManager.LoadScene("PERDISTE");
            Vidas = 4;
            puntaje = 0;
        }

        if (puntaje >= 100)
        {
            SceneManager.LoadScene("Win");
            puntaje = 0;
            Vidas = 4;

        }
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