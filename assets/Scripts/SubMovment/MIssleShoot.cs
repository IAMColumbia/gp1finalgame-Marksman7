using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MIssleShoot : MonoBehaviour
{

    // private bool ShootOkay = false;
    public static int score = 0;

    public Text ScoreT;

    private int Scorin; //Records for tracker

    private int SCorp;

    public GameObject Win;

    public int scoreTotaln = 1000;

    
    //private float Delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Scorin >= scoreTotaln)
        {
            Win.SetActive(true);
        }
        score = SCorp;
        ScoreT.text = "Score: " + MIssleShoot.score.ToString();
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootOkay = true;

            Invoke("NoShoot", Delay);
        }*/
    }

    /*private void NoShoot()
    {
        ShootOkay = false;
    }*/

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            SCorp += 1;
            Destroy(other.gameObject);
            
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            SCorp += 2;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Ship"))
        {
            SCorp += 3;
            Scorin += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("LessMoveingShip"))
        {
            SCorp += 5;
            Scorin += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("AirCraft"))
        {
            SCorp += 10;
            Scorin += 1;
            Destroy(other.gameObject);
        }

    }
}
