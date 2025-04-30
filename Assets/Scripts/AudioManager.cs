using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip bandaSonora;
    public AudioClip fxButton;
    public AudioClip fxCoin;

    public AudioClip fxDead;

    public AudioClip fxFire;

    AudioSource _audioSource;

    public static AudioManager Instance;

 void Awake(){
        DontDestroyOnLoad(this.gameObject);
        if(Instance != null && Instance != this){
            Destroy(this.gameObject);
        }else{ Instance = this;
        DontDestroyOnLoad(this.gameObject);} 
        }
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = bandaSonora;
       _audioSource.loop = true;
        _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SonarClip(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}
