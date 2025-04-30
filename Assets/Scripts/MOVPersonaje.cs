using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVPersonaje : MonoBehaviour
{

    public float multiplicador = 5f;

    public float multiplicadorSalto = 5f;   // Start is called before the first frame update

    public bool puedoSaltar = true;


    public static bool miraDerecha = true;
    private Rigidbody2D rb;

    private Animator animatorController;

    bool soyAzul;

    GameObject respawn;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();

        respawn = GameObject.Find("Respawn");

        transform.position = respawn.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.estoyMuerto) return;


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


        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            miraDerecha = false;
        }
        else if (movTeclas > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            miraDerecha = true;
        }

        //ANIMACION MOVIMIENTO

        if (movTeclas != 0)
        {
            animatorController.SetBool("activaCamina", true);
        }
        else { animatorController.SetBool("activaCamina", false); }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.55f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if (hit)
        {
            puedoSaltar = true;
            //Debug.Log(hit.collider.name);
        }
        else
        {
            puedoSaltar = false;
        }



        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)

          //FIXED SALTO
          
                  



        {
            rb.AddForce(new Vector2(0, multiplicadorSalto),
            ForceMode2D.Impulse);
            puedoSaltar = false;

        }

        if (transform.position.y <= -7)
        {
            Respawnear();
        }
    /// CERO VIDAS!
    
    if(GameManager.vidas <= 0){
      GameManager.estoyMuerto = true;

    }




    }

    public void Respawnear()
    {
        Debug.Log("vidas: "+GameManager.vidas);
        GameManager.vidas = GameManager.vidas - 1;
        Debug.Log("vidas: "+GameManager.vidas);
        


        transform.position = respawn.transform.position;
    }


        public void CambiarColor (){
            if (soyAzul){
            this.GetComponent<SpriteRenderer>().color = Color.white; soyAzul = false;}else{
                 this.GetComponent<SpriteRenderer>().color = Color.blue; soyAzul = true;
            };

        }
        


}