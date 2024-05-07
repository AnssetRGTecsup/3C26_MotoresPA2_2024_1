/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictorySceneController : MonoBehaviour
{
    public Button menuButton;
    public Button playAgainButton;
    public string MenuScene;
    public string GameScene;

    void Start()
    {
        menuButton.onClick.AddListener(LoadMenuScene);
        playAgainButton.onClick.AddListener(LoadGameScene);
    }

    private void LoadMenuScene()
    {
        if (!string.IsNullOrEmpty(MenuScene) && SceneManager.sceneCountInBuildSettings > 0)
        {
            SceneManager.LoadScene(MenuScene);
        }
        else
        {
            Debug.LogWarning("La escena no existe o no se puede cargar.");
        }
    }

    private void LoadGameScene()
    {
        if (!string.IsNullOrEmpty(GameScene) && SceneManager.sceneCountInBuildSettings > 0)
        {
            SceneManager.LoadScene(GameScene);
        }
        else
        {
            Debug.LogWarning("La escena no existe o no se puede cargar.");
        }
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VictorySceneController : MonoBehaviour
{
    public Button btnPlay1;
    public Button btnPlay2;

    void Start()
    {
        btnPlay1.onClick.AddListener(() => ReturnMenu());
        btnPlay2.onClick.AddListener(() => ReturnGame());
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    void ReturnGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}