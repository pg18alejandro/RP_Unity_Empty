using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;

    [SerializeField]
    private float _horizontalSpeed;

    private Rigidbody2D _rb;
    internal bool Playing = false;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if(Playing)
        {
            _rb.velocity = new Vector2(_horizontalSpeed, _rb.velocity.y);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                _rb.velocity = new Vector2 (_rb.velocity.x, _jumpForce);
            }
        }

        else
        {
            transform.position = Vector2.zero;
        }
    }
}
