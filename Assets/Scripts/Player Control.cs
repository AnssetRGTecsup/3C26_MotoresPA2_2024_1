using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] RhythmTempo beatTempo;
    [SerializeField] private Rigidbody2D myRBD2;
    [SerializeField] private float speed = 5f;
    [SerializeField, Range(0f, 2f)] private float MoveTime = 0.25f;
    [SerializeField] private float SmoothFactor = 1f;

    private bool _canAct = true;
    private Vector2 _movementInput;
    private float _moveInterval = 1.0f;
    private void Start()
    {
        StartCoroutine(MoveAtIntervals());
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _movementInput = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            _movementInput = Vector2.zero;
        }
    }

    private IEnumerator MoveAtIntervals()
    {
        while (true)
        {
            if (_canAct)
            {
                StartCoroutine(SmoothMovement(_movementInput));
            }
            yield return new WaitForSeconds(_moveInterval);
        }
    }

    private IEnumerator SmoothMovement(Vector2 direction)
    {
        _canAct = false;

        Vector2 startPosition = myRBD2.position;
        Vector2 endPosition = startPosition + direction.normalized * speed;

        float _time = 0f;

        while (_time < beatTempo.GetScaledBeatTime(MoveTime))
        {
            _time += Time.deltaTime;

            myRBD2.position = Vector2.Lerp(startPosition, endPosition, _time / beatTempo.GetScaledBeatTime(MoveTime) * SmoothFactor);

            yield return null;
        }

        myRBD2.position = endPosition;

        _canAct = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(enemy);
            SceneManager.LoadScene("Pantalla de perde");

        }
    }
}
