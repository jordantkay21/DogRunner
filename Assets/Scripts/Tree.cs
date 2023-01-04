using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private float _speed;



    #endregion

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.localScale = new Vector3((Random.Range(1,3)), (Random.Range(1, 3)), (Random.Range(1, 3)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * _speed * Time.deltaTime);

        if (transform.position.x > 0)
        {
            Destroy(this.gameObject);
        }
    }
}
