using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public GameObject puntos;
    public GameObject player;
    int puntuacion = 0;
    public Text textoPuntuacion;

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
        if (collision.gameObject.name == "Puntos")
        {
            puntuacion++;
        }
        textoPuntuacion.text = puntuacion.ToString();


    }
}
