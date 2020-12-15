using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mark crated this help from a unity from started by Kastenessen, I took tomuch time doing it until i realized it is not a 3d but it is 2d (which ment I did not need lerp for this)
public class Watcher : MonoBehaviour
{
    //public Transform Center;

    private Vector3 Centers = new Vector3(0, 0, 0);

    private Vector3 KTC; //Kyle the Cannon

    //private float speed = 2.0f;
    void Start()
    {

    }

    // Help from youtube: Krister Cederlund : Rotate towards object in 3D - Unity [ENG]
    void Update()
    {
        KTC = this.transform.position;


        float angle = Mathf.Atan2(Centers.y - KTC.y, Centers.x - KTC.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, (angle - 90)));

        //nope
        //Vector3 director = Center.position - transform.position;
        //Quaternion rotator = Quaternion.LookRotation(director);
        //transform.rotation = Quaternion.Lerp(transform.rotation, rotator, speed * Time.deltaTime);
    }
}
