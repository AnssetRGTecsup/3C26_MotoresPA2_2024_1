using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class musica : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    public static event Action parar;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
