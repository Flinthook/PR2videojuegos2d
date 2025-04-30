using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float velocidadParallax = 1;
    GameObject miCamara;
    // Start is called before the first frame update
    void Start()
    {
        miCamara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Camera.main.transform.position);

        // Adjust the z position to ensure the clouds are visible
        transform.position = new Vector3(Camera.main.transform.position.x/velocidadParallax, Camera.main.transform.position.y/velocidadParallax, -10);
    }
}