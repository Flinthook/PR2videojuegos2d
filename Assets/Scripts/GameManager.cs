using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Required for TextMeshProUGUI

public class GameManager : MonoBehaviour
{
    public static int vidas = 5;
    public static int puntos = 0;
    public static int muertes = 0;
    public static bool estoyMuerto = false;

    private TextMeshProUGUI vidasText; // Correct type for TextMeshProUGUI

    void Start()
    {
        // Find the TextMeshProUGUI component for "VidasText"
        GameObject vidasTextObject = GameObject.Find("VidasText");
        if (vidasTextObject != null)
        {
            vidasText = vidasTextObject.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            Debug.LogError("VidasText GameObject not found in the scene!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Puntos: " + puntos);
        Debug.Log("Muertes: " + muertes);

        // Update the text if vidasText is assigned
        if (vidasText != null)
        {
            vidasText.text = vidas.ToString();
        }
    }
}