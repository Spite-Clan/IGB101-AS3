using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStand: MonoBehaviour
{
    public GameObject TeleportTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 200, other.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
