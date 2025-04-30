using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioScript : MonoBehaviour
{


    GameObject panelSettings;



    void Start()
    {
        panelSettings = GameObject.Find("PanelSettings");
        panelSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ESCENA UNO");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void MostrarSettings()
    {
        panelSettings.SetActive(true);
        AudioManager.Instance.SonarClip(AudioManager.Instance.fxDead);

    }

    public void OcultarSettings()
    {
        panelSettings.SetActive(false);
    }

    public void SuenaBoton()
    {
        AudioManager.Instance.SonarClip(AudioManager.Instance.fxButton);
    }
}
