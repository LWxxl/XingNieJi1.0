using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour {
    public Animation opendoor;
    private void Start()
    {
        opendoor = this.GetComponent<Animation>();
    }
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            opendoor.Play();
        }
    }
}
