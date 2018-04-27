using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public ScrollCirlce scroll;
    public Animator animator;

    void Start()
    { 
        animator = this.GetComponent<Animator>();
        animator.SetBool("walk", false);
        animator.SetBool("stand", true);
        animator.SetBool("shoot", false);
    }

    void Update()
    {
        if (scroll.Change.x != 0 || scroll.Change.z != 0)
        {
            animator.SetBool("stand", false);
            animator.SetBool("walk", true);
            transform.Translate(scroll.Change * Time.deltaTime * 40, Space.World);
        }
        if (scroll.Change.x < 0.01 && scroll.Change.x > -0.01 && scroll.Change.z < 0.01 && scroll.Change.z > -0.01)
        {
            animator.SetBool("stand", true);
            animator.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("shoot", true);
            StartCoroutine(WaitThreeMinutines());
        }

    }

    IEnumerator WaitThreeMinutines()
    {
        yield return new WaitForSeconds(2.00f);
        animator.SetBool("shoot",false);
    }
}