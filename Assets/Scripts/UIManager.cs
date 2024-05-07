using UnityEngine;
public class UIManagerController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    public void ActivateMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void DisableMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}