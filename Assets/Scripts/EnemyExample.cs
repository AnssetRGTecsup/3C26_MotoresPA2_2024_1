using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { UP, DOWN, LEFT, RIGHT }

public class EnemyExample : MonoBehaviour
{
    [SerializeField] RhythmTempo beatTempo;
    [SerializeField] private Vector3 weakPoint;
    public GameData _gameData;
    [SerializeField] private Sprite UpSprite, DownSprite, LeftSprite, RightSprite;
    private SpriteRenderer mySR;

    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
        weakPoint = WeakPoint();
        if(weakPoint == Vector3.up)
        {
            mySR.sprite = UpSprite;
        }
        else if (weakPoint == Vector3.down)
        {
            mySR.sprite = DownSprite;
        }
        else if(weakPoint == Vector3.right)
        {
            mySR.sprite = RightSprite;
        }
        else if (weakPoint == Vector3.left)
        {
            mySR.sprite = LeftSprite;
        }
    }
    void Update()
    {
        if(weakPoint == _gameData.PlayerDirection)
        {
            Destroy(this.gameObject);
            _gameData.EnemyQuant--;
        }
    }
    private Vector3 WeakPoint()
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
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        _gameData.EnemyQuant--;
    }
}