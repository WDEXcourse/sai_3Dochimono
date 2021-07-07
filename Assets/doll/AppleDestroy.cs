using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroy : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Basket")
        { 
            Destroy(this.gameObject, 0.1f);
        }
        if (other.gameObject.tag == "Ground")
        { 
            Destroy(this.gameObject, 0.01f);
        }
    }
}