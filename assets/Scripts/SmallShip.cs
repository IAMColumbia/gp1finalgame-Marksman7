using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallShip : MonoBehaviour
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

        transform.Translate(0, Speed * Time.deltaTime, 0);


        if (StartMovement == true)
        {
            

            if (this.gameObject.transform.position.x < (Centers.x + 8) && this.gameObject.transform.position.y < (Centers.y + 8) && this.gameObject.transform.position.x > (Centers.x - 8) && this.gameObject.transform.position.y > (Centers.y - 8))
            {
                StartMovement = false;
            }

        }
        

        if (StartMovement == false)
        {
            KTC = this.transform.position;


            float angle = Mathf.Atan2(Centers.y - KTC.y, Centers.x - KTC.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle)));
        }

    }
}
