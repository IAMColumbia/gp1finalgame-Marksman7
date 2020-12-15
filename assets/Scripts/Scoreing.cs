using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreing : MonoBehaviour
{
    // Not In Use because I  dont like it

    public static int Life = 0;

    public static int score = 0;

    public static int Level = 0;

    public int Lifeok = 0;

    public int scoreok = 0;

    public Text LifeT, LevelT, ScoreT;
    
    void Start()
    {
            LifeT.text = "Lives: " + Scoreing.Life.ToString();
            LevelT.text = "Level: " + Scoreing.Level.ToString();
            ScoreT.text = "Score: " + Scoreing.score.ToString();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Life = Lifeok;
        LifeT.text = "Lives: " + Scoreing.Life.ToString();
        LevelT.text = "Level: " + Scoreing.Level.ToString();
        ScoreT.text = "Score: " + Scoreing.score.ToString();
    }
}
