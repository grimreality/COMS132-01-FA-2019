using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{


    public GameObject cubeprefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubeprefab);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubeprefab);
    }
}
