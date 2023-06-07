using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    //I used this script, to give the coins a visual touch
   
    private float speed = 180; //I have put the rotation speed of the coins here

    void Update()
    {
        //here we tell him to rotate on himself with x
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
