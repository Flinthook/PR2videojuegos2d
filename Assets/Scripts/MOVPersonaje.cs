using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVPersonaje : MonoBehaviour
{

    public float multiplicador = 5f;

    public float multiplicadorSalto = 5f;   // Start is called before the first frame update

    public bool puedoSaltar = true;
    private Rigidbody2D rb;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        float movTeclas = Input.GetAxis("Horizontal"); //(-1f -  1f)
        /*        
       transform.position = new Vector3 (
       transform.position.x + (movTeclas/100),
           transform.position.y,
           transform.position.z
       ); */


        float miDeltaTime = Time.deltaTime;
        /*
            transform.Translate (
                movTeclas*Time.deltaTime*multiplicador ,
                0,
                0
            ); */

        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);


        if (movTeclas < 0 ){
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if (movTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
        }


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.55f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if (hit)
        {
            puedoSaltar = true;
            Debug.Log(hit.collider.name);
        }
        else
        {
            puedoSaltar = false;
        }



        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            rb.AddForce(new Vector2(0, multiplicadorSalto),
            ForceMode2D.Impulse);
            puedoSaltar = false;

        }



    }

    /*    void OnCollisionEnter2D()
        {
            puedoSaltar = true;
        } */


}