using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Apple;
    void Start()
    {
        InvokeRepeating("Generate", 1, 1);
    }

    // Update is called once per frame
    void Generate()
    {
        float x = Random.Range(-30f, 30f);
        float y = 30f;
        float z = Random.Range(-30f, 30f);
        Vector3 position = new Vector3(x, y, z);

        Instantiate(Apple, new Vector3(x, y, z), Quaternion.identity);
    }
}