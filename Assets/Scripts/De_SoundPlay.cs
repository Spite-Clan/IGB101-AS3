using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class De_SoundPlay : MonoBehaviour
{
    public int collectedItemsTrigger;
    public AudioSource effect;
    GameManager gameManager;
    bool playing;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            if (gameManager.currentPickups == collectedItemsTrigger)
            {
                effect.Play();
                playing = true;
            }
        }
    }
}
