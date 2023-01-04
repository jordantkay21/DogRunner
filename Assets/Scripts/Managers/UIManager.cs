using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    #region Variables
    [Header("Texts")]
    [SerializeField]
    private TextMeshProUGUI _bonesCollectedText;

    [Header("Variables")]
    private int _bonesCollected;
    private int _lives;

    [Header("UI Components")]
    [SerializeField]
    private GameObject _3life;
    [SerializeField]
    private GameObject _2life;
    [SerializeField]
    private GameObject _1life;
    [SerializeField]
    private GameObject _0life;


    #endregion

    private void Start()
    {
        NullCheck();
        _lives = 3;
    }

    private void NullCheck()
    {
        if (_bonesCollectedText == null)
        {
            Debug.LogError(gameObject.name + " Failed to Connect to BonesCollectedText");
        }
    }

    // Update is called once per frame
    void Update()
    {

        SetBoneCollectedText();
        DisplayHealth();
    }

    #region BonesCollected

    public void UpdateCollectedBones(int bones)
    {
        _bonesCollected = bones;
    }

    private void SetBoneCollectedText()
    {
        _bonesCollectedText.SetText("Bones Collected: " + _bonesCollected);
    }

    #endregion

    #region Health
    
    public void HealthCheck(int lives)
    {
        _lives = lives;
    }

    private void DisplayHealth()
    {
        if (_lives == 3)
        {
            _3life.SetActive(true);
            _2life.SetActive(false);
            _1life.SetActive(false);
            _0life.SetActive(false);
        }
        else if (_lives == 2)
        {
            _3life.SetActive(false);
            _2life.SetActive(true);
            _1life.SetActive(false);
            _0life.SetActive(false);
        }
        else if (_lives == 1)
        {
            _3life.SetActive(false);
            _2life.SetActive(false);
            _1life.SetActive(true);
            _0life.SetActive(false);
        }
        else if (_lives == 0)
        {
            _3life.SetActive(false);
            _2life.SetActive(false);
            _1life.SetActive(false);
            _0life.SetActive(true);
        }
    }

    #endregion

}
