using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 2)]
public class GameData : ScriptableObject
{
    public int EnemyQuant = 0;
    public Vector3 PlayerDirection = Vector3.zero;
}
