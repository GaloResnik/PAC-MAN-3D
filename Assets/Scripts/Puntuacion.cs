using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    int puntuacion = 0;
    public Text textoPuntuacion;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if (puntuacion == 246)
        {
            panel.gameObject.SetActive(true);
        }
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
