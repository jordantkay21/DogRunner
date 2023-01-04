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
    [SerializeField]
    private UIManager _ui;

    [Header("Player Attributes", order = 2)]
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _animSpeed;
    [SerializeField]
    private int _lives;

    private float _direction;
    private int _bonesCollected;

    private void Start()
    {
        NullCheck();
        SetAnimSpeed();
        _bonesCollected = 0;
        _lives = 3;
    }

    private void NullCheck()
    {
        if (_input == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to PlayerInput");
        }
        if (_anim == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to Animator");
        }
        if (_controller == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to Controller");
        }
        if (_ui == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to UIManager");
        }
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
            _lives -= 1;
            _ui.HealthCheck(_lives);
        }
        else if (other.tag == "Car")
        {
            _lives -= 1;
            _ui.HealthCheck(_lives);
        }
        else if (other.tag == "Bone")
        {
            _bonesCollected += 1;
            _ui.UpdateCollectedBones(_bonesCollected);
            Destroy(other.gameObject);
        }
    }

    #endregion
}
