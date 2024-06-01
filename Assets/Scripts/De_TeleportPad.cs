using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanK_TeleportPad : MonoBehaviour
{
    GameObject Player;
    public GameObject TeleportPad;
    public GameObject TeleportDestination;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Player.GetComponent<CharacterController>().enabled = false;
            Player.transform.position = TeleportDestination.transform.position;
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
