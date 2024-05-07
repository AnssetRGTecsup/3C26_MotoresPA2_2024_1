using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{

    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
  
}