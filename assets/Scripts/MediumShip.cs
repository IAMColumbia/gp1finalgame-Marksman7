using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumShip : MonoBehaviour
{
    private float Speed = 6.0F;

    private bool StartMovement = true;

    private Vector3 Centers = new Vector3(0, 0, 0);

    private Vector3 KTC; //Kyle the Cannon

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();


    }

    private void Movement()
    {
        


        if (StartMovement == true)
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);

            if (this.gameObject.transform.position.x < (Centers.x + 14) && this.gameObject.transform.position.y < (Centers.y + 14) && this.gameObject.transform.position.x > (Centers.x - 14) && this.gameObject.transform.position.y > (Centers.y - 14))
            {
                StartMovement = false;
            }

        }

        

    }
}
