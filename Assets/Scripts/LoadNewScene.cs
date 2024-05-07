using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    //[SerializeField] private string sceneName;
    public void NewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
