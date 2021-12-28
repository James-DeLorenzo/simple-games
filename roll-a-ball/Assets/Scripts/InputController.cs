using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{

    [SerializeField] InputAction BoardTilt;
    [SerializeField] float lerpDamping = 2;

    void Start()
    {
        BoardTilt.Enable();
    }

    void Update()
    {
        // read input and apply tilt to the gameboard
        var inputValue = BoardTilt.ReadValue<Vector2>();
        Vector2 desiredTilt = inputValue != null ? inputValue : Vector2.zero;
        var desiredRotation = Quaternion.Euler(desiredTilt.x, 0, desiredTilt.y);
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * lerpDamping);
    }

}
