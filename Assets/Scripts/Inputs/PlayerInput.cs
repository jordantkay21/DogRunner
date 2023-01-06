using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputAction _input;

    [SerializeField]
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputAction();
        _input.Dog.Enable();

        _input.Dog.QuitFullScreen.performed += QuitFullScreen_performed;
    }

    private void QuitFullScreen_performed(InputAction.CallbackContext obj)
    {
        Application.Quit();
    }



    // Update is called once per frame
    void Update()
    {

        SetDirection();
    }

    void SetDirection()
    {
        float direction = _input.Dog.Movement.ReadValue<float>();
        _player.SetDirection(direction);
    }
}
