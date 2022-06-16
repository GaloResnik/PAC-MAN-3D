using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateDeath : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawnPoint)
        {
            while (a < 2)
            {
                prefab.transform.position = spawnPoint.transform.position;
                Instantiate(prefab);
                a++;
            }
        }
    }

}
