using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //since the island is always going to be at 0, 0  in unity that is the code but in mono game instead of 0, 0 it will be center of view point x and y

    private float Speed = 2.0f;
    private float Xing = 0;
    private float Ying = 0;
    
    void FixedUpdate()
    {
        

        

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        if (Xing > this.transform.position.x)
        {
            if (Ying > this.transform.position.y)
            {
               transform.Translate(Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }
            else if (Ying < this.transform.position.y)
            {
                transform.Translate(Speed * Time.deltaTime, -Speed * Time.deltaTime, 0);
            }
            else
            {
                transform.Translate(Speed * Time.deltaTime, 0, 0);
            }
        }
        else if (Xing < this.transform.position.x)
        {
            if (Ying > this.transform.position.y)
            {
                transform.Translate(-Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }
            else if (Ying < this.transform.position.y)
            {
                transform.Translate(-Speed * Time.deltaTime, -Speed * Time.deltaTime, 0);
            }
            else
            {
                transform.Translate(-Speed * Time.deltaTime, 0, 0);
            }

        }
        else if (Ying > this.transform.position.y)
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }
        else if (Ying < this.transform.position.y)
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
    }
}
