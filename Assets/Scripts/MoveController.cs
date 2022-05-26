using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IPlayerControl
{

    public float HorizontalAxis => Input.GetAxis("Horizontal") * Time.deltaTime;
    public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;
    public float JumpAxis => Input.GetAxis("Jump") * Time.deltaTime;

    public void Horizontal(Transform _transform, float _horizontalSpeed)
    {
        _transform.position += new Vector3(HorizontalAxis * _horizontalSpeed,0,0);

    }

    public void Vertical(Transform _transform, float _verticalSpeed)
    {
        _transform.position += new Vector3(0,0,VerticalAxis * _verticalSpeed);

    }


    public void Jump(Rigidbody _rigidBody,float _jumpForce)
    {

        _rigidBody.AddForce(Vector3.up * _jumpForce * JumpAxis);

        


    }




}
