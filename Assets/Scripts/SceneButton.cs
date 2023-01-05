using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneButton : MonoBehaviour
{
    [SerializeField]
    private int _sceneToLoad;

    [SerializeField]
    private GameManager _gameManager;

    private void Start()
    {
        if (_gameManager == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to GameManager");
        }
    }
    public void OnButtonPress()
    {
        _gameManager.LoadScene(_sceneToLoad);
    }
}
