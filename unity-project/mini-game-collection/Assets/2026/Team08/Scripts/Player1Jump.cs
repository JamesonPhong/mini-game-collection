using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player1Jump : MonoBehaviour
{   
    float position;

    float timer = 5;

    bool hasJumped;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (hasJumped == false)
            {
                hasJumped = true;
                position += 2; //Moves their y position up
                
            }


        }
        else if (hasJumped == true) 
        {
            if (timer < 0)
            {
                position -= 2;
                hasJumped = false;
                timer = 500;
            }
            else if (timer >= 0) { timer = timer - 1; } //Counts down how long they can stay in the air
        }

        transform.position = new Vector3(transform.position.x, position, transform.position.z);
    }
}
