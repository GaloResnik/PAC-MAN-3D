using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public GameObject prefab;
    public AudioClip eatSound;
    AudioSource fuenteAudio;
    public GameObject panel;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO DEL JUGADOR
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

        //TP A LOS COSTADOS DEL MAPA
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
        //CONTADOR DE PUNTOS
        
        if (collision.gameObject.name == "Puntos")
        {
            count++;
            fuenteAudio.clip = eatSound;
            fuenteAudio.Play();
        }

        //DESTUYE OBJETO POR FANTASMA
        if (collision.gameObject.name == "Ghost")
        {
            int a = 0;
            while (a < count)
            {
                prefab.transform.position = gameObject.transform.position;
                Instantiate(prefab);
                a++;
            }
            Destroy(gameObject);
            panel.gameObject.SetActive(true);
        }
    }


}
