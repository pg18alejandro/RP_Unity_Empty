using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Collider2D))]
public class CollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameDirector _gDirector;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            _gDirector.Death();
        }

        if(other.gameObject.CompareTag("CheckPoint"))
        {
            _gDirector.AddPoints(1);
        }
    }
}
