using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private PlayerController _player;

    [SerializeField]
    private TextMeshProUGUI _scoreText;

    private int _score;

    private gState _gState = gState.StartPoint;

    public enum gState{
        StartPoint,
        Playing,
        Death
    }

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        _scoreText.text = _score.ToString();

        if(Input.GetKeyDown(KeyCode.Space) && _gState == gState.StartPoint)
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        _player.Playing = true;
        _player._rb.isKinematic = false;
        _gState = gState.Playing;
    }

    public void Death()
    {
        _player.Playing = false;
        _player._rb.isKinematic = true;
        _gState = gState.Death;
    }

    public void AddPoints( int point)
    {
        _score += point;
    }
}
