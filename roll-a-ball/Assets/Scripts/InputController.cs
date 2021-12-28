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
        Vector2 inputValue = BoardTilt.ReadValue<Vector2>();
        Vector2 desiredTilt = inputValue != null ? inputValue : Vector2.zero;
        var desiredRotation = Quaternion.Euler(desiredTilt.y, 0, -desiredTilt.x);
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * lerpDamping);
    }

}
