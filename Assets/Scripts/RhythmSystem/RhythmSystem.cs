using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RhythmSystem : MonoBehaviour
{
    [SerializeField] RhythmTempo beatTempo;
    public GameData _gameData;

    public static event Action OnBeat;
    public static event Action<float> OnTimeIncrease;

    private float scaleTime = 0;

    [SerializeField] private GameObject Enemy;

    private void Start()
    {
        StartCoroutine(RhythmCompas());
    }
    void OnDestroy()
    {
        _gameData.EnemyQuant = 0;
    }

    private IEnumerator RhythmCompas()
    {
        float _time = 0;

        while(_time < beatTempo.BeatTime * 0.8f)
        {
            _time += Time.deltaTime;
            scaleTime = _time;

            yield return null;

            float ratio = scaleTime / beatTempo.BeatTime;

            OnTimeIncrease?.Invoke(ratio);
        }

        OnBeat?.Invoke();

        while (_time < beatTempo.BeatTime)
        {
            _time += Time.deltaTime;
            scaleTime = _time;

            yield return null;

            float ratio = scaleTime / beatTempo.BeatTime;

            OnTimeIncrease?.Invoke(ratio);
        }

        //Alonso
        if(_gameData.EnemyQuant < 1)
        {
            CreateEnemy();
        }
        //Alonso

        StartCoroutine(RhythmCompas());
    }
    public void CreateEnemy()
    {
        Instantiate(Enemy);
        _gameData.EnemyQuant++;
    }
}
