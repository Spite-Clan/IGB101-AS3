using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class De_Pickup : MonoBehaviour
{
    GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
