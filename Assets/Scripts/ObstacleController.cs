﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float _separation;

    public GameObject pipe;

    private Vector3 lastPosition;

    private void Start()
    {
        lastPosition =  new Vector3(1,0,0);
        InvokeRepeating("AddObstacle", 0, 1f);
    }


    private void AddObstacle()
    {
        lastPosition.y = Random.Range(-0.5f, 6.5f);
        GameObject newPipe = Instantiate(pipe, lastPosition, Quaternion.identity);
        float spawnNumber = Random.Range(0, 100);
        
        if (spawnNumber >= 60)
        {
            newPipe.transform.GetChild(0).gameObject.SetActive(true); 
            newPipe.transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            newPipe.transform.GetChild(0).gameObject.SetActive(false); 
            newPipe.transform.GetChild(1).gameObject.SetActive(true);
        }
        lastPosition.x += _separation;
    }

}
