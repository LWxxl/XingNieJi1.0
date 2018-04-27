using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//相机跟随
public class FollowPlayer : MonoBehaviour
{
    private Vector3 targetPosition;     // the position the camera is trying to be in  
    private Transform follow;

    void Start()
    {
        follow = GameObject.FindWithTag("Player").transform;
       // transform.LookAt(follow.position);
        targetPosition = transform.position - follow.position;
    }

    void Update()
    {

        transform.position = targetPosition + follow.position;
    }
}