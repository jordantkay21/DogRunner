using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Components", order =1)]
    [SerializeField]
    private PlayerInput _input;
    [SerializeField]
    private Animator _anim;

    [Header("Player Attributes", order = 2)]
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _animSpeed;

    private float _direction;

    private void Start()
    {

    }

    private void Update()
    {
        movement();
        SetAnimSpeed();
    }

    #region Movement
    public void SetDirection(float direction)
    {
        _direction = direction;
    }

    private void SetAnimSpeed()
    {
        _anim.SetFloat("Speed_f", _animSpeed);
    }

    private void movement()
    {
        transform.Translate(new Vector3(_direction, 0) * _speed * Time.deltaTime);
    }

    #endregion
}
