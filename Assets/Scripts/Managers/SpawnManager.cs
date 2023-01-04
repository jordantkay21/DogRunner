using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> _carsList = new List<GameObject>();
    [SerializeField]
    private GameObject _carContainer;

    [SerializeField]
    private float _carSpawnSpeed;

    private bool _stopSpawning = false;

    private 
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnCarsLeftRoutine());
        StartCoroutine(SpawnCarsRightRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCarsLeftRoutine()
    {


        yield return new WaitForSeconds(2.0f);
        while (_stopSpawning == false)
        {
            int random = Random.Range(0, _carsList.Count - 1);

            Vector3 posToSpawn = new Vector3(-120, 0, Random.Range(-26, -23));
            GameObject newCar = Instantiate(_carsList[random], posToSpawn, Quaternion.LookRotation(Vector3.left));
            newCar.transform.parent = _carContainer.transform;
            yield return new WaitForSeconds(Random.Range(2,4));

        }
    }

    IEnumerator SpawnCarsRightRoutine()
    {

        yield return new WaitForSeconds(2.0f);
        while (_stopSpawning == false)
        {
            int random = Random.Range(0, _carsList.Count - 1);

            Vector3 posToSpawn = new Vector3(-120, 0, Random.Range(-19, -16));
            GameObject newCar = Instantiate(_carsList[random], posToSpawn, Quaternion.LookRotation(Vector3.left));
            newCar.transform.parent = _carContainer.transform;
            yield return new WaitForSeconds(Random.Range(2,4));
        }
    }
}
