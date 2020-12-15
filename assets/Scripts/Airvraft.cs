using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airvraft : MonoBehaviour
{

    private float Speed = 6.0F;

    private bool StartMovement = true;

    private bool GoAway = false;

    private bool ChangeDirections = true;

    private bool BIO = false; //Back in orenation

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

        if (GoAway == true)
        {
            MoveingAway();
        }
    }

    private void Movement()
    {
        if (StartMovement == true)
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);

            if (this.gameObject.transform.position.x < (Centers.x + 8) && this.gameObject.transform.position.y < (Centers.y + 8) && this.gameObject.transform.position.x > (Centers.x - 8) && this.gameObject.transform.position.y > (Centers.y - 8))
            {
                StartMovement = false;
            }

        }

        if (this.gameObject.transform.position.x > (Centers.x + 12) || this.gameObject.transform.position.y > (Centers.y + 12) || this.gameObject.transform.position.x < (Centers.x - 12) || this.gameObject.transform.position.y < (Centers.y - 12))
        {
            BIO = true;
        }

        if (this.gameObject.transform.position.x < (Centers.x + 8) && this.gameObject.transform.position.y < (Centers.y + 8) && this.gameObject.transform.position.x > (Centers.x - 8) && this.gameObject.transform.position.y > (Centers.y - 8))
        {
            BIO = false;
        }

        if(StartMovement == false)
        {
            KTC = this.transform.position;


            float angle = Mathf.Atan2(Centers.y - KTC.y, Centers.x - KTC.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle - 90)));
        }

    }

    private void MoveingAway()
    {
        if (ChangeDirections == true)
        {
            if (BIO == true)
            {
                transform.Translate(Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }
            else
            {

                transform.Translate(Speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            if (BIO == true)
            {
                transform.Translate(-Speed * Time.deltaTime, Speed * Time.deltaTime, 0);
            }
            else
            {

                transform.Translate(-Speed * Time.deltaTime, 0, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        


        if (other.gameObject.CompareTag("MoveBetterAim"))
        {
            GoAway = true;

            

            if (ChangeDirections == true)
            {
                ChangeDirections = false;
            }
            else
            {
                ChangeDirections = true;

            }
        }
        
    }
}
