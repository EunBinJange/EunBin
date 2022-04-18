using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    //void SayHello(string name)
    //{
    //    Debug.Log("Hello "+name);
    //}

    void Start()
    {
        //int x = 1;
        //if (x == 1)
        //{
        //    int y = 2;
        //    Debug.Log(x);
        //    Debug.Log(y);
        //}
        //Debug.Log(y);
        //SayHello("Tom");

        
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x +=8.0f;
        playerPos.y +=5.0f;
        Debug.Log(playerPos);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
