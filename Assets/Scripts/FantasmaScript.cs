using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FantasmaScript : MonoBehaviour
{
    Vector3 posicionInicial;
    GameObject rogue;

public float velocidadFantasma = 10.0f;

AudioSource _audioSource;



    void Start()
    {
        posicionInicial = transform.position;
        rogue = GameObject.Find("rogue");


        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       float distancia = Vector3.Distance(transform.position, rogue.transform.position);

       float velocidadFinal = velocidadFantasma * Time.deltaTime;

       //Debug.Log(distancia);
       
        if(distancia <= 8.5f){
            //ACCION!
        transform.position = Vector3.MoveTowards(transform.position, rogue.transform.position, velocidadFinal);

        _audioSource.Play();

        if (_audioSource.isPlaying == false){
            _audioSource.Play();
        }


        }else{    
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);
             }

       // Debug.DrawLine(transform.position, rogue.transform.position, Color.white, 2.5f);

    }
}
