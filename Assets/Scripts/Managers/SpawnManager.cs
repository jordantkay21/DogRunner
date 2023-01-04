using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Objects to Spawn")]
    [SerializeField]
    private List<GameObject> _carsList = new List<GameObject>();
    [SerializeField]
    private GameObject _bone;
    [SerializeField]
    private List<GameObject> _treesList = new List<GameObject>();

    [Header("Object Containers")]
    [SerializeField]
    private GameObject _carContainer;
    [SerializeField]
    private GameObject _boneContainer;
    [SerializeField]
    private GameObject _treeContainer;

    [Header("Spawn Times")]
    [SerializeField]
    private float _carSpawnSpeed;
    [SerializeField]
    private float _boneSpawnSpeed;

    private bool _stopSpawning = false;

    private 
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnCarsLeftRoutine());
        StartCoroutine(SpawnCarsRightRoutine());
        StartCoroutine(SpawnBoneRoutine());
        StartCoroutine(SpawnTreesLeftRoutine());
        StartCoroutine(SpawnTreesRightRoutine());
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

    IEnumerator SpawnBoneRoutine()
    {
        yield return new WaitForSeconds(4.0f);
        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(-120, 1, Random.Range(-30, -12));
            GameObject newBone = Instantiate(_bone, posToSpawn, Quaternion.LookRotation(Vector3.up));
            newBone.transform.parent = _boneContainer.transform;
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }

    IEnumerator SpawnTreesLeftRoutine()
    {


        yield return new WaitForSeconds(2.0f);
        while (_stopSpawning == false)
        {
            int random = Random.Range(0, _treesList.Count - 1);

            Vector3 posToSpawn = new Vector3(-120, 0, Random.Range(-62,-32));
            GameObject newCar = Instantiate(_treesList[random], posToSpawn, Quaternion.identity);
            newCar.transform.parent = _treeContainer.transform;
            yield return new WaitForSeconds(Random.Range(2, 4));

        }
    }

    IEnumerator SpawnTreesRightRoutine()
    {


        yield return new WaitForSeconds(2.0f);
        while (_stopSpawning == false)
        {
            int random = Random.Range(0, _treesList.Count - 1);

            Vector3 posToSpawn = new Vector3(-120, 0, Random.Range(-10, 20));
            GameObject newCar = Instantiate(_treesList[random], posToSpawn, Quaternion.identity);
            newCar.transform.parent = _treeContainer.transform;
            yield return new WaitForSeconds(Random.Range(2, 4));

        }
    }
}
