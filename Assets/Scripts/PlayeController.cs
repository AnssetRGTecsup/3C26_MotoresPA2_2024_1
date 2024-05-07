using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int player_lives = 4;
    private bool isInvulnerable = false;
    private Collider2D myCollider;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    public void OnButtonPressed(InputAction.CallbackContext context)
    {
        

    }

    public void FlipRight(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            Flip(true);
        }
    }

    public void FlipLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Flip(false);
        }
    }

    void Flip(bool faceRight)
    {

        if (faceRight)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    public void InDamage()
    {

    }
    IEnumerator Invulnerability()
    {
        myCollider.enabled = false;
        isInvulnerable = true;
        yield return new WaitForSeconds(2f);
        myCollider.enabled = true;
        isInvulnerable = false;
    }
}