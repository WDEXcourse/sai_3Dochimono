﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip SE1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
