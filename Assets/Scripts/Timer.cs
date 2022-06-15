using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtMuestratiempo;
    float currentTime;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.timeSinceLevelLoad;
        txtMuestratiempo.text = (100 - Mathf.Floor(currentTime)).ToString();
        if (currentTime == 100)
        {
            Destroy(player);
            //Mostrar texto de que perdiste
        }
    }
}
