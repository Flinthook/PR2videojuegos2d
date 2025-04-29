using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{
    Animator miAnimadorController;
    // 
    //  before the first frame update
    void Start()
    {
        miAnimadorController = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col){


        if(col.name == "rogue"){
            GameManager.puntos += 1;
            miAnimadorController.SetBool("monedaDestruir", true);

            Destroy(this.gameObject, 1.25f);
        }


    }



}
