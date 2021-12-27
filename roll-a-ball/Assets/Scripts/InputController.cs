using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{

    //[SerializeField] InputAction up = KeyCode.W;
    //[SerializeField] KeyCode down = KeyCode.S;
    //[SerializeField] KeyCode left = KeyCode.A;
    //[SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] InputAction BoardTilt;
    [SerializeField] float maxTilt = 10;
    [SerializeField] float lerpDamping = 2;

    void Start()
    {
        BoardTilt.Enable();
    }
    void Update()
    {
        // TODO: get new input system working
        if(BoardTilt.enabled)
            print(BoardTilt.ReadValueAsObject());
        //Vector3 targetRotation = Vector3.zero;
        //if (Input.GetKey(up))
        //    targetRotation.x = maxTilt;
        //if (Input.GetKey(down))
        //    targetRotation.x = -maxTilt;
        //if (Input.GetKey(left))
        //    targetRotation.z = maxTilt;
        //if (Input.GetKey(right))
        //    targetRotation.z = -maxTilt;

        //var desiredRotation = Quaternion.Euler(targetRotation.x, targetRotation.y, targetRotation.z);

        //transform.rotation =  Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * lerpDamping);

        //Input
    }

}
