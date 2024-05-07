using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            GameManager.Vidas = GameManager.Vidas - 1;

            Destroy(this.gameObject);
        }
        if (collision.tag == "Shield")
        {
            GameManager.puntaje = GameManager.puntaje + 10;
            Destroy(this.gameObject);
        }
    }

}
