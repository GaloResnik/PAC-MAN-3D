using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public GameObject player;
    AudioSource fuenteAudio;
    public AudioClip constantSound;
    public GameObject panelGanaste;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            fuenteAudio.volume = 0;
        }
    }
}
