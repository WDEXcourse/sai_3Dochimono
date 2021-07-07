using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    public float Randompos;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Randompos = Random.Range(1,5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Randompos == 1)
        {
            transform.position = new Vector3(0.3f, 0.1f, -0.1f);
        }
        if (Randompos == 2)
        {
            transform.position = new Vector3(25, 0.1f, 18.2f);
        }
        if (Randompos == 3)
        {
            transform.position = new Vector3(22.5f, 0.1f, -17.6f);
        }
        if (Randompos == 4)
        {
            transform.position = new Vector3(-23.2f, 0.1f, -0.1f);
        }
        if (Randompos == 5)
        {
            transform.position = new Vector3(-23.2f, 0.1f, -18.3f);
        }
    }    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Debug.Log("aaaaa");
            SceneManager.LoadScene("GameOver");
        }
    }
}