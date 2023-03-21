using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclesPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int obstaclesIndex = Random.Range(0, 4);

            Instantiate(obstaclesPrefabs[obstaclesIndex], new Vector3(0, 0, -5), obstaclesPrefabs[obstaclesIndex].transform.rotation);
        }
    }
}
