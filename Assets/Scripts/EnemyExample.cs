using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { UP, DOWN, LEFT, RIGHT }

public class EnemyExample : MonoBehaviour
{
    [SerializeField] RhythmTempo beatTempo;

    [Header("Smooth Translate Values")]
    [SerializeField, Range(0f, 2f)] private float MoveTime = 0.25f;
    [SerializeField] private float SmoothFactor = 1f;

    private bool _canAct = true;

    private void OnEnable()
    {
        RhythmSystem.OnBeat += CallSmoothMovement;
    }

    private void OnDisable()
    {
        RhythmSystem.OnBeat -= CallSmoothMovement;
    }

    private void CallSmoothMovement()
    {
        if (!_canAct) return;

        StartCoroutine(SmoothMovement());
    }

    private IEnumerator SmoothMovement()
    {
        _canAct = false;

        Vector3 startPosition = transform.position;
        Vector3 endPosition = transform.position + Movement();

        float _time = 0f;

        while (_time < beatTempo.GetScaledBeatTime(MoveTime))
        {
            _time += Time.deltaTime;

            transform.position = Vector3.Lerp(startPosition, endPosition, _time * SmoothFactor);

            yield return null;
        }

        transform.position = endPosition;

        _canAct = true;
    }

    private Vector3 Movement()
    {
        Direction randomDirection = (Direction)Random.Range(0, 4);

        switch (randomDirection)
        {
            case Direction.UP:
                return Vector3.up;
            case Direction.DOWN:
                return Vector3.down;
            case Direction.LEFT:
                return Vector3.left;
            case Direction.RIGHT:
                return Vector3.right;
        }

        return Vector3.zero;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this);
        }
    }
}
