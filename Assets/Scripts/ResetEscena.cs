using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResetEscena : MonoBehaviour
{
    public Button btnPlay;
   
    void Start()
    {
        btnPlay.onClick.AddListener(() => ReturnMenu());
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
