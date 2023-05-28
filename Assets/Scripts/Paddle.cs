using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Allows other paddle scripts to access class
    protected Rigidbody2D _rigidbody;
    public float _speed = 10f;

    // Calls once for entire lifecycle of scripts
    private void Awake()
    {
        // Check for Rigid body component
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
