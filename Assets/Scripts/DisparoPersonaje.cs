using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{
    public GameObject fuego; // Regular fireball
    public GameObject fuegoGrande; // Bigger fireball
    public float holdTimeThreshold = 1.0f; // Time required to charge the bigger fireball

    private float buttonHoldTime = 0f; // Tracks how long the button is held

    void Update()
    {
        // Check if the fire button is being held
        if (Input.GetKey(KeyCode.E))
        {
            buttonHoldTime += Time.deltaTime; // Increment hold time
        }

        // Check if the fire button is released
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (buttonHoldTime >= holdTimeThreshold)
            {
                // Shoot a bigger fireball
                Instantiate(fuegoGrande, transform.position, Quaternion.identity);
            }
            else
            {
                // Shoot a regular fireball
                Instantiate(fuego, transform.position, Quaternion.identity);
            }

            // Play the fire sound
            AudioManager.Instance.SonarClip(AudioManager.Instance.fxFire);

            // Reset the hold time
            buttonHoldTime = 0f;
        }
    }
}