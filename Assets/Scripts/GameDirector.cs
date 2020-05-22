using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private PlayerController _player;

    private int _score;

    private gState _gState = gState.StartPoint;

    public enum gState{
        StartPoint,
        Playing,
        Death
    }

    private void Start()
    {
        _score = 00;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _gState == gState.StartPoint)
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        _player.Playing = true;
        _gState = gState.Playing;
    }

    private void Death()
    {
        
    }
}
