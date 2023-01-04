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
    [SerializeField]
    private CharacterController _controller;

    [Header("Player Attributes", order = 2)]
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _animSpeed;

    private float _direction;

    private void Start()
    {
        SetAnimSpeed();
    }

    private void Update()
    {
        Movement();
        Bounds();

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

    private void Movement()
    {
        transform.Translate(new Vector3(_direction, 0) * _speed * Time.deltaTime);
    }

    private void Bounds()
    {
        if (transform.position.z < -30)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -30f);
        }

        if (transform.position.z > -12)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -12);
        }
    }

    #endregion

    #region Colliders

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Object")
        {
            Debug.Log("Hit Object : " + other.name);
        }
        else if (other.tag == "Car")
        {
            Debug.Log("Hit Car");
        }
        else if (other.tag == "Bone")
        {
            Debug.Log("Collected Bone");
        }
    }

    #endregion
}
