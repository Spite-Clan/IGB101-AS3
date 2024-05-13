using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{

    public GameObject player;
    //Pickup and Completion
    public int currentPickups = 0;
    public int maxPickups = 9;
    public bool levelComplete = false;

    //UI components
    public Text pickupText;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    //Completion Check
    private void LevelCompleteCheck(){
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    //UI updater
    private void UpdateGUI(){
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }

    //Loop for playing audio proximity events - AudioSource based
    private void PlayAudioSamples(){
        for (int i = 0; i < audioSources.Length; i++){
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity){
                if (!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }
}
