using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public static int Life = 0;

    //public static int score = 0;

    public static int Level = 0;

    

    public Text LifeT, LevelT;
    /// ScoreT

    public GameObject Lose, Win, Pause;

    private int HealthPoints = 100;

    private int LevelPoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelPoints = SceneManager.GetActiveScene().buildIndex;
        Level = LevelPoints;
        Life = HealthPoints;
        LifeT.text = "Health: " + Health.Life.ToString();
        LevelT.text = "Level: " + Health.Level.ToString();
        //ScoreT.text = "Score: " + Health.score.ToString();

        if(HealthPoints < 0)
        {
            Lose.SetActive(true);
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            HealthPoints = HealthPoints - 10;
            //bombsound
            Destroy(other.gameObject);
            
        }

        /*if (other.gameObject.CompareTag("DedBomb"))
        {
            //maybe as a gig, or if there are ice bergs that will happen
        }*/

        if (other.gameObject.CompareTag("Bullet"))
        {
            HealthPoints = HealthPoints - 1;
            //bullet hitting sound
            Destroy(other.gameObject);
        }
    }
    
    

}
