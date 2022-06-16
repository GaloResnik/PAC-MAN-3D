using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtMuestratiempo;
    float currentTime;
    public GameObject player;
    public GameObject panel;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.timeSinceLevelLoad;
        if (player)
        {
            txtMuestratiempo.text = (80 - Mathf.Floor(currentTime)).ToString();
        }

        if (currentTime >= 80 && count <245)
        {
            Destroy(player);
            panel.gameObject.SetActive(true);
        }
    }
}
