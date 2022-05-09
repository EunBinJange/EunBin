using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontroller : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 100.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        
        StartPos = new Vector3(0,0,0);
        ballRd.AddForce (-speed, 0f, speed * 0.7f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag ("WALL"))
        {
            Vector3 currpos = collision.transform.position;

            vector3 incomVec = currPos - startPos;
            Vector3 normalvec = collision.contacts [0].normal;
            vector reflectVec = Vector3.Reflect (incomVec,normalvec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec*speed);
        }
        startPos = transform.position;
    }
}
