using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RhythmSystem : MonoBehaviour
{
    [SerializeField] RhythmTempo beatTempo;

    public static event Action OnBeat;
    public static event Action OnBeatstop;
    public static event Action<float> OnTimeIncrease;

    private float scaleTime = 0;

    private void Start()
    {
        StartCoroutine(RhythmCompas());
    }

    private IEnumerator RhythmCompas()
    {
        float _time = 0;
        OnBeat?.Invoke();
        while (_time < beatTempo.BeatTime * 0.8f)
        {
            _time += Time.deltaTime;
            scaleTime = _time;

            yield return null;

            float ratio = scaleTime / beatTempo.BeatTime;

            OnTimeIncrease?.Invoke(ratio);
        }

        OnBeatstop?.Invoke();

        while (_time < beatTempo.BeatTime)
        {
            _time += Time.deltaTime;
            scaleTime = _time;

            yield return null;

            float ratio = scaleTime / beatTempo.BeatTime;

            OnTimeIncrease?.Invoke(ratio);
        }

        StartCoroutine(RhythmCompas());
    }
}
