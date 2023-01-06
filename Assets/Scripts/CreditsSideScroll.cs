using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsSideScroll : MonoBehaviour
{

    [SerializeField]
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * _speed * Time.deltaTime);

        if (transform.position.x > 0)
        {
            transform.position = new Vector3(-75.2f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
