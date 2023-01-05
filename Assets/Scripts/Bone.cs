using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    private float _degreesPerSecond = 40;
    private float _speed = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, _degreesPerSecond) * Time.deltaTime);
        transform.Translate(new Vector3(1, 0, 0) * _speed * Time.deltaTime, Space.World);
    }

}
