using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{
    // Start is called before the first frame
    //  update
    public GameObject fuego;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)){

            Instantiate(fuego, transform.position, Quaternion.identity);
            
        }



    }
}
