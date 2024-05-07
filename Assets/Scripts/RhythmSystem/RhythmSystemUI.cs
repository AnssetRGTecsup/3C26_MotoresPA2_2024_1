using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RhythmSystemUI : MonoBehaviour
{
    [SerializeField] private Image compas;
    [Header("Transform Properties")]
    [SerializeField] private RectTransform startPos;
    [SerializeField] private RectTransform endPos;

    [Header("Scale Properties")]
    [SerializeField, Range(0.1f, 0.85f)] private float minScale = 0.25f;
    [SerializeField, Range(0.85f, 1.5f)] private float maxScale = 1.25f;

    [Header("Color Properties")]
    [SerializeField] private Color startColor;
    [SerializeField] private Color endColor;
    [SerializeField] private float colorOffset = 0.55f;


    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    private float _startPos;
    private float _endPos;

    private void Awake()
    {
        _startPos = startPos.position.x;
        _endPos = endPos.position.x;
    }

    private void OnEnable()
    {
        RhythmSystem.OnTimeIncrease += ScaleCompas;
        RhythmSystem.OnTimeIncrease += MoveCompas;
        RhythmSystem.OnTimeIncrease += UpdateColor;
        RhythmSystem.OnBeat += CompasReached;
    }

    private void OnDisable()
    {
        RhythmSystem.OnTimeIncrease -= ScaleCompas;
        RhythmSystem.OnTimeIncrease -= MoveCompas;
        RhythmSystem.OnTimeIncrease -= UpdateColor;
        RhythmSystem.OnBeat -= CompasReached;
    }

    private void ScaleCompas(float value)
    {
        float _scaleValue = Mathf.Lerp(minScale, maxScale, value);
        compas.rectTransform.localScale = new Vector3(_scaleValue, _scaleValue, _scaleValue);
    }

    private void MoveCompas(float value)
    {
        float _moveValue = Mathf.Lerp(_startPos, _endPos, value);
        compas.rectTransform.position = new Vector3(_moveValue ,compas.rectTransform.position.y, compas.rectTransform.position.z);
    }

    private void UpdateColor(float value)
    {
        if(value < colorOffset)
        {
            compas.color = Color.Lerp(startColor, endColor, value);
        }
        else
        {
            compas.color = Color.Lerp(endColor, startColor, value - colorOffset);
        }
    }

    private void CompasReached()
    {
        audioSource.PlayOneShot(audioClip);
    }
}