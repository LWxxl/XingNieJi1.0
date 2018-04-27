using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Checka : MonoBehaviour
{
    public GameObject JinDuTiao;

    private float surrentAmout = 0;
    private float m_speed = 5;

    // Use this for initialization
    void Start()
    {
        JinDuTiao.SetActive(false);
    }

    private void Update()
    {
        if (JinDuTiao.active == true && surrentAmout < 100)
        {
            surrentAmout += m_speed * Time.deltaTime;
            Debug.Log(surrentAmout);


        }
        JinDuTiao.GetComponent<Image>().fillAmount = surrentAmout / 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            JinDuTiao.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            surrentAmout = 0;
            JinDuTiao.SetActive(false);
        }
    }
}
