using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//占领据点是出现的进度条 

public class Jindu : MonoBehaviour
{

    public Transform myProgress;
  //  public Transform sexText;
  //  public Transform loadingText;
    private float surrentAmout = 0;
    private float m_speed = 5;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(surrentAmout < 100)
        {
            surrentAmout += m_speed * Time.deltaTime;
          //  sexText.GetComponent<Text>().text = ((int)surrentAmout).ToString() + "%";
          //  sexText.gameObject.SetActive(false);
        }
        else
        {
           // loadingText.GetComponent<Text>().text = "占领完成";
           // sexText.gameObject.SetActive(false);
        }
        myProgress.GetComponent<Image>().fillAmount = surrentAmout / 100;
	}
}
