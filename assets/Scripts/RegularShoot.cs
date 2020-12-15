using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularShoot : MonoBehaviour
{

    private float Delay = 4.0f;
    public GameObject Bulle;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShootAtPlayer", Delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

    private void ShootAtPlayer()
    {
        if (this.gameObject.activeSelf == true)
        {
            Instantiate(Bulle, this.transform.TransformPoint(0, 1, 0), this.gameObject.transform.rotation);
            Delay = Random.Range(3.0f, 4.0f);

            Invoke("ShootAtPlayer", Delay);

        }
    }
}
