using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
        private GameObject rogue;
        private MOVPersonaje movPersonaje;
        void Start()
    {
        rogue = GameObject.Find("rogue");
        movPersonaje = rogue.GetComponent<MOVPersonaje>();
        movPersonaje.Respawnear();
    }

    // Update is called once per frame
    void Update()
    {
        


    
    }

  void OnTriggerEnter2D(Collider2D col){
   movPersonaje.Respawnear();
    }

}

