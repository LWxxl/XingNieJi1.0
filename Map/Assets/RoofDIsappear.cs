using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDIsappear : MonoBehaviour {

    public GameObject roof;
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hourse")
        {
            Debug.Log("aaaaa");
            roof.SetActive(false);
            Door.SetActive(false);
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Hourse")
    //    {
    //        Debug.Log("nbbb");
    //        roof.SetActive(true);
    //        Door.SetActive(true);
    //    }
    //}
}
