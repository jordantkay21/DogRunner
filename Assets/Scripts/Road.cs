using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{

    #region Variables

    [SerializeField]
    private float _speed;



    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * _speed * Time.deltaTime);

        if(transform.position.x > 0)
        {
            transform.position = new Vector3(-116, 0.19f, -11);
        }
    }
}
