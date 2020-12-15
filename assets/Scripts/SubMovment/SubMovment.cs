using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovment : MonoBehaviour
{
    private float Delay = (1.0f / 2);

    float Speed = 90.0F;

    float SpeedMovent = 10.0F;

    public GameObject Pause;

    private bool CheckerInvort = false;

    private Vector3 Centers = new Vector3(0, 0, 0);

    private bool Back = false;

    public float ScreenHeight = 0;

    public float ScreenWidth = 0;

    public Vector3 RecordStart;

    // Start is called before the first frame update
    void Start()
    {
        RecordStart = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal") * Speed;
        HorizontalMovement *= Time.deltaTime;

        transform.Rotate(0, 0, -HorizontalMovement);

        ScreenHeight = Screen.height / 34;
        ScreenWidth = Screen.width / 32;

        float VerticalMovement = Input.GetAxis("Vertical") * SpeedMovent;
        VerticalMovement *= Time.deltaTime;

        //transform.Translate(0, -VerticalMovement, 0);
        if (CheckerInvort == false)
        {

            if ((this.transform.position.y < (Centers.y + 3.5) && this.transform.position.y > (Centers.y - 3.5) && this.transform.position.x < (Centers.x + 3.5) && this.transform.position.x > (Centers.x - 3.5)
                && !(this.transform.position.y > (Centers.y + 2.5) && this.transform.position.x > (Centers.x + 2.5)) && !(this.transform.position.y > (Centers.y + 2.5) && this.transform.position.x < (Centers.x - 2.5))
                && !(this.transform.position.y < (Centers.y - 2.5) && this.transform.position.x > (Centers.x + 2.5)) && !(this.transform.position.y < (Centers.y - 2.5) && this.transform.position.x < (Centers.x - 2.5))
                && !(this.transform.position.y > (Centers.y + 1.5) && this.transform.position.x > (Centers.x + 3)) && !(this.transform.position.y > (Centers.y + 3) && this.transform.position.x > (Centers.x + 1.5))
                && !(this.transform.position.y > (Centers.y + 1.5) && this.transform.position.x < (Centers.x - 3)) && !(this.transform.position.y > (Centers.y + 3) && this.transform.position.x < (Centers.x - 1.5))
                && !(this.transform.position.y < (Centers.y - 1.5) && this.transform.position.x > (Centers.x + 3)) && !(this.transform.position.y < (Centers.y - 3) && this.transform.position.x > (Centers.x + 1.5))
                && !(this.transform.position.y < (Centers.y - 1.5) && this.transform.position.x < (Centers.x - 3)) && !(this.transform.position.y < (Centers.y - 3) && this.transform.position.x > (Centers.x - 1.5)))
                || (this.transform.position.y > ScreenHeight || this.transform.position.y < -ScreenHeight || this.transform.position.x > ScreenWidth || this.transform.position.x < -ScreenWidth))
            {
                transform.Translate(0, VerticalMovement, 0);
                Back = true;
                Invoke("DontHitIsland", Delay);
            }
            else
            {
                if (Back == true)
                {
                    transform.Translate(0, VerticalMovement, 0);
                }
                else
                {
                    transform.Translate(0, -VerticalMovement, 0);
                }
            }
        }

        PauseingUpdate();//pause game

        Boarders();//this method is if the player ends up getting out of bouns, so it spawns them with in bound

    }

    void Boarders()
    {
        if(this.transform.position.y > (ScreenHeight + 5) || this.transform.position.y < (-ScreenHeight - 5) || this.transform.position.x > (ScreenWidth + 5) || this.transform.position.x < (-ScreenWidth - 5))
        {
            this.transform.position = (RecordStart);
        }
    }
    

    void DontHitIsland()
    {
        Back = false;
    }

    void PauseingUpdate()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (CheckerInvort == false)
            {
                Pause.SetActive(true);
                CheckerInvort = true;
                Time.timeScale = 0;
            }
            else
            {
                Pause.SetActive(false);
                CheckerInvort = false;
                Time.timeScale = 1;

            }
        }
    }


}
