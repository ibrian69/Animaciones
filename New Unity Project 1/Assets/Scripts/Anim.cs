using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Anim : MonoBehaviour
{
    Animator animacion;
    // Use this for initialization
    void Awake()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animacion.SetBool("IsWalk", true);           
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animacion.SetBool("IsRunning", true);
        }        
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animacion.SetBool("IsWalk", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animacion.SetBool("IsRunning", false);            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animacion.SetBool("IsJump", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animacion.SetBool("IsJump", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animacion.Play("Light Punch");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animacion.Play("Light Kick");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animacion.Play("Jump Punch");
        }
    }
}
