using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    Vector2 inputDirection;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        myRigidbody.velocity = inputDirection;
    }

    void OnMove(InputValue value)
    {
        inputDirection = value.Get<Vector2>();
    }
}
