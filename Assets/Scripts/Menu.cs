using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{
    public GameObject IndicacionesObjeto;

    
    
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }
   
    public void Indicaciones()
    {
        IndicacionesObjeto.SetActive(true);
    }
    public void Desaparecer()
    {
        IndicacionesObjeto.SetActive(false);
    }

}
