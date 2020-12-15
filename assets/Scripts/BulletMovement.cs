using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float Speed = 2.0f;

    private int ScreenHeight = 100;
    private int   ScreenWidth = 100;

    // Start is called before the first frame update
    void Start()
    {
        ScreenHeight = Screen.height / 34;
        ScreenWidth = Screen.width / 32;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * Speed, 0);

    }


    void OutOfBounds()
    {
        if (this.transform.position.y > (ScreenHeight + 5) || this.transform.position.y < (-ScreenHeight - 5) || this.transform.position.x > (ScreenWidth + 5) || this.transform.position.x < (-ScreenWidth - 5))
        {
            Destroy(this.gameObject);
        }
    }
}
