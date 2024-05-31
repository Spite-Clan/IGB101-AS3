using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanK_DoorUse : MonoBehaviour
{
    GameManager gameManager;
    bool opening;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.currentPickups >= 2 && !opening)
        //if (Input.GetKeyDown(KeyCode.F))
        {
            DoorActivate();
            opening = true;
        }
    }

    private void DoorActivate()
    {
        GetComponent<Animation>().Play();
    }
}
