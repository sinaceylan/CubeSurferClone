using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    List<GameObject> cube = new List<GameObject>();

    public int maxCube = 5;

    [SerializeField] private GameObject cubePrefab;

    void Update()
    {
        if (cube.Count<maxCube) 
        {
            Vector3 randomSapwnPosition = new Vector3(Random.Range(-2.87f, 3.26f), 0.802f, Random.Range(4.41f, 33.31f));
            Instantiate(cubePrefab, randomSapwnPosition, Quaternion.identity);
            cube.Add(cubePrefab);   
        }  
    }
}
