using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [Header("Components")]
    [SerializeField]
    private UIManager _ui;
    [SerializeField]
    private SpawnManager _spawnManager;
    [SerializeField]
    private AudioSource _gameAudioSource, _BackgroundAudioSource;
    [SerializeField]
    private AudioClip _BoneCollectedAudio, _skidSound, _dogBark;


    [Header("Attributes")]
    private bool _isGameOver;



    // Start is called before the first frame update
    void Start()
    {
        NullCheck();

    }

    private void NullCheck()
    {
        if (_gameAudioSource == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to AudioSource");
        }
        if (_ui == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to UIManager");
        }
        if (_spawnManager == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to SpawnManager");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        _isGameOver = true;
        _spawnManager.OnPlayerDeath();
        _ui.GameOverSequence();
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    #region Sound

    public void PlayCarSkid()
    {
        _gameAudioSource.clip = _skidSound;
        _gameAudioSource.Play();
    }

    public void BoneCollectedSound()
    {
        _gameAudioSource.clip = _BoneCollectedAudio;
        _gameAudioSource.Play();
    }

    public void DogBarkSound()
    {
        _gameAudioSource.clip = _dogBark;
        _gameAudioSource.Play();
    }

    #endregion
}
