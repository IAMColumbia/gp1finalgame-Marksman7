using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSheild : MonoBehaviour
{

    float Speed = 100.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float HorizontalMovement = Input.GetAxis("RotateIslandSheildSecond") * Speed;
        HorizontalMovement *= Time.deltaTime;

        transform.Rotate(0, 0, HorizontalMovement);
    }
}
