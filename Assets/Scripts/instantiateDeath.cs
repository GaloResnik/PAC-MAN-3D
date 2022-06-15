using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateDeath : MonoBehaviour
{
    public GameObject prefab;
    public GameObject deathPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ghost")
        {
            Destroy(gameObject);
            int a = 0;
            while (a < 10)
            {
                GameObject clon;
                clon = Instantiate(prefab);
                clon.transform.position = deathPoint.transform.position;
            }
        }
    }
}
