using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Player Config")]

    [SerializeField] Transform _playerTransform;
    [SerializeField] float _speed, _jumpForce;
    [SerializeField] Rigidbody _playerRigidBody;
    bool _isJump;
    MoveController _moveController;
    [SerializeField] Animator _animator;

    private void Awake()
    {
        _moveController = new MoveController();
    }
    private void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJump = true;
        }
        else
        {
            _isJump = false;
        }
    }



    void Walk()
    {
        _moveController.Horizontal(_playerTransform, _speed);
        _moveController.Vertical(_playerTransform, _speed);
    
    }
    void Jump()
    {

        if (_isJump)
        {
            _moveController.Jump(_playerRigidBody, _jumpForce);
            _animator.SetBool("_Jump",true);

        }


    }


}
