using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
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
