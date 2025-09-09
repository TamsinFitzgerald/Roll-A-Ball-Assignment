using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;


    void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (movehorizontal, 0.0f, movevertical);   //X , Y , Z

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);  //0x5=0, stand
                                                                                //1x5=5,move
                                                                                //0+5=5, standError=StillMoving
                                                                                //1+5=6, moveError=FasterThanItShouldBe
    }

}


