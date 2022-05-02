using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 1.0f; //속도

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            playerRd.AddForce(-speed, 0f, 0f);
            //transform.Translate (Vector3.left * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            playerRd.AddForce (speed, 0f, 0f);
            //transform.Translate (Vector3.right * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRd.AddForce(0f, 0f, speed);
            //transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            playerRd.AddForce(0f, 0f, -speed);
        //    //transform.Translate (Vector3.back * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Space)==true)
        {
            playerRd.AddForce(0f, speed, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag ("WALL"))
        {
            Debug.Log("Collision");
        }
    }
}
