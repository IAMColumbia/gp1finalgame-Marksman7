using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSheild : MonoBehaviour
{

    float Speed = 120.0F;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float HorizontalMovement = Input.GetAxis("RotateIslandSheild") * Speed;
        HorizontalMovement *= Time.deltaTime;

        transform.Rotate(0, 0, HorizontalMovement);
        
    }
}
