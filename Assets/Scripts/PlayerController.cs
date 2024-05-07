using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public void Hit(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //enemyPrefab.GetComponent<EnemySpawner>().OnHit();
        }
    }
}
