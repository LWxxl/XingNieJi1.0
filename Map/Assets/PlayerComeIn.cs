using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComeIn : MonoBehaviour
{
    public GameObject roof;
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            roof.SetActive(false);
            Door.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            roof.SetActive(true);
            Door.SetActive(true);
        }
    }
}

