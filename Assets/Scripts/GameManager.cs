using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 5;

    public static int puntos = 0;

    public static bool estoyMuerto = false;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                Debug.Log("Puntos: "+puntos);   
    }
}
