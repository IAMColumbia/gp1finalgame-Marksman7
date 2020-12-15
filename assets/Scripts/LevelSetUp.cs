using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSetUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }

    public void LevelFour()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }

    public void LevelFive()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1;
    }

    public void LevelEndlessOne()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
    }

    public void LevelEndlessTwo()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
    }


}
