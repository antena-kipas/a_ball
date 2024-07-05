using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject _spawnObject;



    void Start()
    {

        Vector3 spawnPosition = new Vector3(3.27f, -0.46f, 0);
        Quaternion spawnRotation = Quaternion.Euler(0, 0, 45);
        Instantiate(_spawnObject, spawnPosition, spawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
