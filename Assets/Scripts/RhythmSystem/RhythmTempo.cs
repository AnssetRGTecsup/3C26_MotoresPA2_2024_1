using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tempo", menuName = "ScriptableObjects/RhythmSystem/Tempo")]
public class RhythmTempo : ScriptableObject
{
    [SerializeField] private float beatTime;

    public float BeatTime => beatTime;

    public float GetScaledBeatTime(float scale)
    {
        return beatTime * scale;
    }

    public float GetOffSetBeatTime(float offset)
    {
        return beatTime + offset;
    }
}
