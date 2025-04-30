using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuegoScript : MonoBehaviour
{

    GameObject rogue;
    bool bolaDerecha = true;

    float tiempoDestruccion = 5.0f;

    void Start()
    {
        rogue = GameObject.Find("rogue");
        bolaDerecha = MOVPersonaje.miraDerecha;

        // Destroy the fireball after 5 seconds
        Destroy(gameObject, tiempoDestruccion);
    }

    // Update is called once per frame
    void Update()
    {
        if (bolaDerecha) // Access miraDerecha statically
        {
            transform.Translate(0.01f, 0, 0, Space.World);
        }
        else
        {
            transform.Translate(-0.01f, 0, 0, Space.World);
        }
    }

    void OnTriggerEnter2D(Collider2D col){
      //  Debug.Log(col.gameObject.name.StartsWith("Fantasma"));

        if(col.gameObject.tag == "Enemigo"){
            Destroy(col.gameObject);

            GameManager.muertes += 1;

            Destroy(this.gameObject);
        }
    }}