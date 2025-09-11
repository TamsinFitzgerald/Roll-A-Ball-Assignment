using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                                           //These must always be at the beginning of a script for the script to comply. So it knows these features that will come up later.


public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;                                                //F = decimal. F is important for classes such as speed. Because if it was an Intiger, Player object would snap instead of moving fluidly.
    public Text ScoreText;
    public GameObject WinText;
    private int count = 0;
    void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (movehorizontal, 0.0f, movevertical);    //X , Y , Z

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);  //0x5=0, stand
                                                                                //1x5=5,move
                                                                                //0+5=5, standError=StillMoving
                                                                                //1+5=6, moveError=FasterThanItShouldBe

        if (count == 5)
        {
            WinText.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)                                 //void=function
    {                                                                           //OnTriggerEnter= If there are colisions with in this script.
                                                                                //if colliding with pick up object with a tag it will disappear because it is set to false.
                                                                                //if there is no tag on object it will stay true and will not disappear.
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            ScoreText.text = "Score: " + count;
        }
    }
}


