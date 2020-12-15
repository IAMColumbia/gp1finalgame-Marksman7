using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float Delay = 6.0f;

    public GameObject Ship;

    public GameObject ReShip;

    public GameObject MediumShip;

    public GameObject AirCraft;

    public GameObject Bomb;

   // public GameObject Sub;

    public GameObject Island;

    private int Randy = 0;

    private int Directions = 0;

    private int SpawnY = 0;

    private int SpawnX = 0;

    private int Decide = 0;

    private int Flip = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Island, this.transform.TransformPoint(0, 0, 0), this.gameObject.transform.rotation);

        //Instantiate(Sub, this.transform.TransformPoint(0, -6, 0), this.gameObject.transform.rotation);

        Invoke("Spawn", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {

        Randy = Random.Range(0, 100);

        Decide = Random.Range(0, 100);

        Flip = Random.Range(0, 100);


        if (Decide >= 50)
        {
            if (Flip >= 50)
            {
                SpawnX = -45;
                SpawnY = (Random.Range(0, 10) - 5);
                Directions = 270;
            }
            else
            {
                SpawnX = 45;
                SpawnY = (Random.Range(0, 10) - 5);
                Directions = 90;
            }
        }
        else
        {
            if (Flip >= 50)
            {
                SpawnY = -20;
                SpawnX = (Random.Range(0, 10) - 5);
                Directions = 0;
            }
            else
            {
                SpawnY = 20;
                SpawnX = (Random.Range(0, 10) - 5);
                Directions = 180;
            }
        }
        


        if (Randy % 20 == 0)
        {
            Instantiate(AirCraft, this.transform.TransformPoint(SpawnX, SpawnY, 0), Quaternion.Euler(new Vector3(0, 0, Directions)));
        }
        else if (Randy % 15 == 0 || Randy % 10 == 0)
        {
            Instantiate(MediumShip, this.transform.TransformPoint(SpawnX, SpawnY, 0), Quaternion.Euler(new Vector3(0, 0, Directions)));
        }
        else if (Randy % 4 == 0)
        {
            Instantiate(ReShip, this.transform.TransformPoint(SpawnX, SpawnY, 0), Quaternion.Euler(new Vector3(0, 0, Directions)));
        }
        else if (Randy % 3 == 0)
        {
            Instantiate(Ship, this.transform.TransformPoint(SpawnX, SpawnY, 0), Quaternion.Euler(new Vector3(0, 0, Directions)));
        }
        else
        {
            Instantiate(Bomb, this.transform.TransformPoint(SpawnX, SpawnY, 0), this.gameObject.transform.rotation);
        }

        if (Delay > 2)
        {
            Delay = Delay - (1/10);
        }

        Invoke("Spawn", Delay);

    }

}
