using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(0, 0, movementSpeed);
        }

        if (transform.position.z > 30)
        {
            transform.position += new Vector3(0, 0, -50);
        }
        if (transform.position.z < -23)
        {
            transform.position += new Vector3(0, 0, 50); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        int count = 0;
        if (collision.gameObject.name == "Punto")
        {
            count++;
        }
        if (collision.gameObject.name == "Ghost")
        {
            Destroy(gameObject);
            int a = 0;
            while (a < count)
            {
                GameObject clon;
                clon = Instantiate(prefab);
                clon.transform.position = gameObject.transform.position;
                a++;
            }
        }
    }


}
