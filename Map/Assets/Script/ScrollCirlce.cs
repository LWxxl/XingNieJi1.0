using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//左下角的手柄

public class ScrollCirlce : ScrollRect
{
    private float Radius;
   // public Vector3 output;
    public Vector3 Change;
    private Vector3 pos;    //中间小球的位置

	void Start ()
    {
        Radius = (transform as RectTransform).sizeDelta.x * 0.4f;  //获取大圆的长度
	}


    //继承了一个接口。重写父类 
    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        pos = content.anchoredPosition;   //获取中心小球额位置
        if (pos.magnitude > Radius)   //中间小球的位置大于半径   就回来
        {
            pos = pos.normalized * Radius;
            SetContentAnchoredPosition(pos);
        }
    }

    void Update()
    {
        pos = content.localPosition / Radius;
        Change.x = pos.x;
        Change.y = 0;
        Change.z = pos.y;
     //   Debug.Log(Mathf.Atan((float)pos.x /(float) pos.y) / Mathf.PI*180);
    }
}
