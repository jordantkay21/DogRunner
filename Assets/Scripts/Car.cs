using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    #region Variables

    [SerializeField]
    private float _speed;



    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _speed = Random.Range(20, 25);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * _speed * Time.deltaTime);

        if (transform.position.x > 0)
        {
            Destroy(this.gameObject);
        }
    }
}
