using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStand: MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTarget;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 200, other.transform.position.z);
        if (other.transform.tag == "Player")
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        OnButtonPress();    
    }

    private void OnButtonPress()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 1, Player.transform.position.z);
        }
    }
}  
